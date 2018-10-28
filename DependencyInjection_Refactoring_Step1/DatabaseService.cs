using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_Refactoring_Step1
{
    class DatabaseService
    {
        public IEnumerable<string> GetParts()
        {
            // Make database Connection
            return new string[] { "PART1", "PART2", "PART3"};
        }
    }
}
