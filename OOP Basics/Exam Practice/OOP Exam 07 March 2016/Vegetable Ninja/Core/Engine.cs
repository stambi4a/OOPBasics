namespace Vegetable_Ninja.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Vegetable_Ninja.Commands;
    using Vegetable_Ninja.Commands.Interfaces;
    using Vegetable_Ninja.Core.Interfaces;
    using Vegetable_Ninja.Factories;
    using Vegetable_Ninja.Models;
    using Vegetable_Ninja.Models.Interfaces;
    using Vegetable_Ninja.UserInterface;
    using Vegetable_Ninja.UserInterface.Interfaces;

    public class Engine : IEngine
    {
        private readonly IDatabase database;
        private readonly IUserInterface userInterface;
        private readonly ICommandExecutor commandExecutor;

        public Engine()
        {
            this.userInterface = new ConsoleUserInterface();
            this.commandExecutor = new CommandExecutor();
            this.database = this.InitializeDatabase();
        }

        public void Run()
        {
            while (true)
            {
                var commandsInput = this.userInterface.ReadLine().ToCharArray();
                bool gameIsOver = false;
                foreach (var commandValue in commandsInput)
                {
                    this.commandExecutor.Execute(commandValue, this.database.CurrentNinjaCoordinates, this.database.Garden);
                    var winner = this.database.CheckIfAttacksAnotherNinja();
                    if (winner != null)
                    {
                        this.userInterface.WriteLine(winner);
                        gameIsOver = true;
                        break;
                    }

                    this.database.CurrentNinjaGatherVegetables();

                    this.Update();
                }
                if (gameIsOver)
                {
                    break;
                }
            }
            
        }

        public void Update()
        {
            this.database.Update();
        }

        private IDatabase InitializeDatabase()
        {
            var nameFirstNinja = this.userInterface.ReadLine();
            var firstNinja = NinjaFactory.CreateNinja(nameFirstNinja);

            var nameSecondNinja = this.userInterface.ReadLine();
            var secondNinja = NinjaFactory.CreateNinja(nameSecondNinja);

            var input = this.userInterface.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = input[0];
            var columns = input[1];
            var rowLayouts = new List<string>();
            for (var i = 0; i < rows; i++)
            {
                var rowLayout = this.userInterface.ReadLine();
                rowLayouts.Add(rowLayout);
            }

            var garden = new Garden(rows, columns, rowLayouts);
            var firstNinjaInitial = nameFirstNinja[0];
            var secondNinjaInitial = nameSecondNinja[0];
            var ninjaCoordinates = this.FindNinjasCoordinates(firstNinjaInitial, secondNinjaInitial, garden);
            garden.PlaceBlankSpaces(ninjaCoordinates);

            var vegetableNinjaDatabase = new Database(garden, new LinkedList<INinja>(new List<INinja>() {firstNinja, secondNinja}), new Dictionary<INinja, int[]>()
                                                                                                                                        {
                { firstNinja, ninjaCoordinates[0] },
                { secondNinja, ninjaCoordinates[1] }
                                                                                                                                        }, firstNinja);

            return vegetableNinjaDatabase;
        }

        private List<int[]> FindNinjasCoordinates(char firstNinjaInitial, char secondNinjaInitial, IGarden garden)
        {
            var ninjaCoordinates = new int[2][];
            for (var i = 0; i < garden.Rows; i++)
            {
                for (var j = 0; j < garden.Columns; j++)
                {
                    if (garden.GardenLayout[i][j] == firstNinjaInitial)
                    {
                        ninjaCoordinates[0] = new[] { i, j };
                    }

                    if (garden.GardenLayout[i][j] == secondNinjaInitial)
                    {
                        ninjaCoordinates[1] = new[] { i, j };
                    }

                    if (ninjaCoordinates[0]  != null && ninjaCoordinates[1] != null)
                    {
                        return ninjaCoordinates.ToList();
                    }                 
                }
            }

            return ninjaCoordinates.ToList();
        }
    }
}
