﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Executor
{
    public class RepositorySorter
    {
        public void OrderAndTake(Dictionary<string, double> studentsWithMarks,
            string comparison, int studentsToTake)
        {
            comparison = comparison.ToLower();
            if (comparison == "ascending")
            {    
                this.PrintStudents(studentsWithMarks.OrderBy(x => x.Value)
                                        .Take(studentsToTake)
                                        .ToDictionary(pair => pair.Key, pair => pair.Value)); 
            }
            else if (comparison == "descending")
            {  
                PrintStudents(studentsWithMarks.OrderByDescending(x => x.Value)
                                        .Take(studentsToTake)
                                        .ToDictionary(pair => pair.Key, pair => pair.Value));
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidComparisonQuery);
            }
        }

        private void PrintStudents(Dictionary<string, double> studentsWithMarks)
        {
            foreach (KeyValuePair<string, double> keyValuePair in studentsWithMarks)
            {
                OutputWriter.PrintStudent(keyValuePair);
            }
        }
    }
}
