namespace Problem_06.Football_Team_Generator
{
    using System;
    using System.Runtime.Remoting.Metadata.W3cXsd2001;

    internal class Player
    {
        private const int MinValue = 0;
        private const int MaxValue = 100;

        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        internal Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.CalculateAverageSkill();
        }

        internal int AverageSkill { get; private set; }

        internal string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty. ");
                }

                this.name = value;
            }
        }

        internal int Endurance
        {
            get
            {
                return this.endurance;
            }

            private set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                }

                this.endurance = value;
            }
        }

        internal int Sprint
        {
            get
            {
                return this.sprint;
            }

            private set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                }

                this.sprint = value;
            }
        }

        internal int Dribble
        {
            get
            {
                return this.dribble;
            }

            private set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException("Dribble should be between 0 and 100.");
                }

                this.dribble = value;
            }
        }

        internal int Passing
        {
            get
            {
                return this.passing;
            }

            private set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException("Passing should be between 0 and 100.");
                }

                this.passing = value;
            }
        }

        internal int Shooting
        {
            get
            {
                return this.shooting;
            }

            private set
            {
                if (value < MinValue || value > MaxValue)
                {
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                }

                this.shooting = value;
            }
        }

        private void CalculateAverageSkill()
        {
            this.AverageSkill = (int)Math.Round((this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0);
        }
    }
}
