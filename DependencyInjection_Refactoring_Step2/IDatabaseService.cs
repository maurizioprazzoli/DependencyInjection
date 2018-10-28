using System.Collections.Generic;

namespace DependencyInjection_Refactoring_Step2
{
    public interface IDatabaseService
    {
        IEnumerable<string> GetParts();
    }
}