using DependencyInjection_Refactoring_Step2;
using System.Collections.Generic;

namespace DependencyInjection_Refactoring_Step2_Test.Mocks
{
    class DatabaseServiceEmptyParts : IDatabaseService
    {
        public IEnumerable<string> GetParts()
        {
            return null;
        }
    }
}
