using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
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
