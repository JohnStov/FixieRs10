using System;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Application;
using JetBrains.Metadata.Reader.API;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.UnitTestFramework;
using JetBrains.Util;
using JetBrains.Util.Logging;

namespace FixieRs10
{
    [SolutionComponent]
    public class FixieTestElementsSource : IUnitTestElementsSource
    {
        private readonly MetadataElementsSource metadataElementsSource;

        public FixieTestElementsSource(FixieTestProvider provider, IShellLocks shellLocks)
        {
            Provider = provider;
            metadataElementsSource = new MetadataElementsSource(Logger.GetLogger(typeof(FixieTestElementsSource)), shellLocks);
        }


        public void ExploreSolution(IUnitTestElementsObserver observer)
        {
            // Do nothing. We find all tests via assembly metadata
        }

        public void ExploreProjects(
            IDictionary<IProject, FileSystemPath> projects, 
            MetadataLoader loader, 
            IUnitTestElementsObserver observer,
            CancellationToken cancellationToken)
        {
            var explorer = new FixieMetadataExplorer();
            metadataElementsSource.ExploreProjects(projects, loader, observer, explorer.ExploreAssembly, cancellationToken);
            observer.OnCompleted();
        }

        public void ExploreFile(IFile psiFile, IUnitTestElementsObserver observer, Func<bool> interrupted)
        {
            // Do nothing. We find all tests via assembly metadata
        }

        public IUnitTestProvider Provider { get; private set; }
    }
}