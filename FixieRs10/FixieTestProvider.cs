using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.TaskRunnerFramework;
using JetBrains.ReSharper.UnitTestFramework;

namespace FixieRs10
{
    [UnitTestProvider, UsedImplicitly]
    public class FixieTestProvider : IUnitTestProvider, IDynamicUnitTestProvider
    {
        public bool IsElementOfKind(IDeclaredElement declaredElement, UnitTestElementKind elementKind)
        {
            throw new NotImplementedException();
        }

        public bool IsElementOfKind(IUnitTestElement element, UnitTestElementKind elementKind)
        {
            throw new NotImplementedException();
        }

        public bool IsSupported(IHostProvider hostProvider)
        {
            throw new NotImplementedException();
        }

        public int CompareUnitTestElements(IUnitTestElement x, IUnitTestElement y)
        {
            throw new NotImplementedException();
        }

        public string ID => "ID";

        public string Name => "Fixie";

        public IUnitTestElement GetDynamicElement(RemoteTask remoteTask, Dictionary<string, IUnitTestElement> taskIdsToElements)
        {
            throw new NotImplementedException();
        }
    }
}