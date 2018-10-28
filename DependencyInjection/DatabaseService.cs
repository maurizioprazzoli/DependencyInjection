using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection
{
    public class DatabaseService
    {
        public IEnumerable<string> GetParts()
        {
            using (var db = new DependencyInjectionDbContext())
            {
                var parts = db.Parts;
                return parts?.Select(p => p.Code).ToList();
            }
        }
    }
}
