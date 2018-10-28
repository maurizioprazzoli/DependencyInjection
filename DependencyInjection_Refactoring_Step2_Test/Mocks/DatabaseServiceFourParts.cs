using DependencyInjection_Refactoring_Step2;
using System.Collections.Generic;

namespace DependencyInjection_Refactoring_Step2_Test.Mocks
{
    class DatabaseServiceFourParts : IDatabaseService
    {
        public IEnumerable<string> GetParts()
        {
            // Make database Connection
            return new string[] { "PART-1", "PART-2", "PART-3", "PART-4"};
        }
    }
}
