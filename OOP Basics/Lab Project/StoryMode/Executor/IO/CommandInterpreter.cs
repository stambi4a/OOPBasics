﻿using System;
using System.Diagnostics;
using System.Text;
using Executor.Network;

namespace Executor
{
    using System.IO;

    using Exceptions;

    using Executor.Commands;

    public class CommandInterpreter
    {
        private Tester judge;
        private StudentsRepository repository;
        private DownloadManager downloadManager;
        private IOManager inputOutputManager;

        public CommandInterpreter(
            Tester judge,
            StudentsRepository repository,
            DownloadManager downloadManager,
            IOManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.downloadManager = downloadManager;
            this.inputOutputManager = inputOutputManager;
        }
        public void InterpredCommand(string input)
        {
            string[] data = input.Split(' ');
            string commandName = data[0].ToLower();
            try
            { 
                var command = this.ParseCommand(input, commandName, data);
                command.Execute();
            }
            catch (Exception e)
            {
                OutputWriter.DisplayException(e.Message);
            }   
        }

        private Command ParseCommand(string input, string commandName, string[] data)
        {
            switch (commandName)
            {
                case "show":
                    return new ShowCourseCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "open":
                    return new OpenFileCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "mkdir":
                    return new MakeDirectoryCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "ls":
                    return new TraverseFoldersCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "cmp":
                    return new CompareFilesCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "cdrel":
                    return new ChangeRelativePathCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "cdabs":
                    return new ChangeAbsolutePathCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "readdb":
                    return new ReadDatabaseCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "dropdb":
                    return new DropDatabaseCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "help":
                    return new GetHelpCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "filter":
                    return new PrintFilteredStudentsCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "order":
                    return new PrintOrderedStudentsCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "download":
                    return new DownloadFileCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                case "downloadasynch":
                    return new DownloadAsynchCommand(input, data, this.judge, this.repository, this.downloadManager, this.inputOutputManager);
                default:
                    throw new InvalidCommandException(input);
            }
        }

        
    }
}
