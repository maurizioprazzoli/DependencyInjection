using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Refactoring_Step1
{
    class PartListCreator
    {
        private DatabaseService _databaseService;

        public PartListCreator(DatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public IEnumerable<string> GetParts()
        {
            var parts = _databaseService.GetParts();
            return parts ?? Enumerable.Empty<string>();
        }
    }
}
