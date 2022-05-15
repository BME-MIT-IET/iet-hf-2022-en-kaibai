using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
using RDFSharp.Semantics.OWL;
using System.Collections.Generic;

namespace RDFSharp.Test.Semantics.OWL
{

    [TestClass]
    public class RDFOntologyFactTest
    {
        static IEnumerable<object[]> DataStatusItemsTestSetupOntologyFact
        {
            get
            {
                return new List<object[]>
                {
                     new object[]{ new RDFResource(("http://hello/world#hi")) }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(DataStatusItemsTestSetupOntologyFact))]
        public void ShouldCreateOntologyFact(RDFResource input1)
        {
            RDFOntologyFact ontologyFact = new RDFOntologyFact(input1);

            Assert.IsNotNull(ontologyFact);
            Assert.IsTrue(ontologyFact.Value.Equals(input1));
        }

        [TestMethod]
        [DataRow(null)]
        public void ShouldNotCreateNullOntologyFact(RDFResource input1)
            => Assert.ThrowsException<RDFSemanticsException>(() => new RDFOntologyFact(input1));
    }
}
