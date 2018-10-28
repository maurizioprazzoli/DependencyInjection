using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_Refactoring_Step2
{
    public class DatabaseService : IDatabaseService
    {
        public IEnumerable<string> GetParts()
        {
            // Make database Connection
            return new string[] { "PART1", "PART2", "PART3"};
        }

    }
}
