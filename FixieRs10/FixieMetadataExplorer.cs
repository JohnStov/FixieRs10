using System.Threading;
using Fixie.Execution;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;

namespace FixieRs10
{
    public class FixieMetadataExplorer
    {
        public void ExploreAssembly(
            IProject project, 
            IMetadataAssembly assembly, 
            IUnitTestElementsObserver observer,
            CancellationToken cancellationToken)
        {
            var environment = new ExecutionEnvironment(assembly.Location.FullPath);
            var methodGroups = environment.DiscoverTestMethodGroups(null);
        }
    }
}
