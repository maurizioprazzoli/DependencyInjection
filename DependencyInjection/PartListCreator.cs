using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection
{
    class PartListCreator
    {
        private DatabaseService _databaseService;

        public PartListCreator()
        {
            _databaseService = new DatabaseService();
        }

        public IEnumerable<string> GetParts()
        {
            var parts = _databaseService.GetParts();
            return parts ?? Enumerable.Empty<string>();
        }
    }
}
