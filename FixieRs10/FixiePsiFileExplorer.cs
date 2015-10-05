using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Tree;

namespace FixieRs10
{
    public class FixiePsiFileExplorer : IRecursiveElementProcessor
    {
        public FixiePsiFileExplorer()
        {
        }

        public bool InteriorShouldBeProcessed(ITreeNode element)
        {
            return true;
        }

        public void ProcessBeforeInterior(ITreeNode element)
        {
        }

        public void ProcessAfterInterior(ITreeNode element)
        {
        }

        public bool ProcessingIsFinished => true;
    }
}