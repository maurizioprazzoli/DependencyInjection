using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Refactoring_Step2
{
    public class PartListCreator
    {
        private IDatabaseService _databaseService;

        public PartListCreator(IDatabaseService databaseService)
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
