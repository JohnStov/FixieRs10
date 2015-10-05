using System.Reflection;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;

namespace FixieRs10
{
    [SolutionComponent]
    public class AssemblyRegistrar
    {
        public AssemblyRegistrar(UnitTestingAssemblyLoader loader)
        {
            loader.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}