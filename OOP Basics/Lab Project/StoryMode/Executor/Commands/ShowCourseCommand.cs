﻿namespace Executor.Commands
{
    using Executor.Exceptions;
    using Executor.Network;

    public class ShowCourseCommand : Command
    {
        public ShowCourseCommand(
            string input,
            string[] data,
            Tester judge,
            StudentsRepository repository,
            DownloadManager downloadManager,
            IOManager inputOutputManager)
            : base(input, data, judge, repository, downloadManager, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length == 2)
            {
                string courseName = this.Data[1];
                this.Repository.GetAllStudentsFromCourse(courseName);
            }
            else if (this.Data.Length == 3)
            {
                string courseName = this.Data[1];
                string UserName = this.Data[2];
                this.Repository.GetStudentScoresFromCourse(courseName, UserName);
            }
            else
            {
                throw new InvalidCommandException(this.Input);
            }
        }
    }
}
