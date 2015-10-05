using System.Threading;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.UnitTestFramework;

namespace FixieRs10
{
    public class FixieMetadataExplorer
    {
        public FixieMetadataExplorer()
        {
        }

        public void ExploreAssembly(
            IProject project, 
            IMetadataAssembly assembly, 
            IUnitTestElementsObserver observer,
            CancellationToken cancellationToken)
        {
        }
    }
}
