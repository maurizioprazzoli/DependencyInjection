using DependencyInjection_Refactoring_Step2;
using System.Collections.Generic;

namespace DependencyInjection_Refactoring_Step2_Test.Mocks
{
    class DatabaseServiceThreeParts : IDatabaseService
    {
        public IEnumerable<string> GetParts()
        {
            // Make database Connection
            return new string[] { "PART1", "PART2", "PART3"};
        }
    }
}
