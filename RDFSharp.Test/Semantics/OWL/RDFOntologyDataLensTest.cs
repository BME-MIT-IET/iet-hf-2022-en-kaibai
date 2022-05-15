using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
using RDFSharp.Semantics.OWL;
using System.Collections.Generic;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyDataLensTest
    {
        static IEnumerable<object[]> DataStatusItemsTestSetupGivenDatalens
        {
            get
            {
                return new List<object[]>
                {
                     new object[]{ new RDFOntologyFact(new RDFResource("http://hello/world#hi")), new RDFOntology(new RDFResource("http://hello/world#hi")) }
                };
            }
        }

        [TestMethod]
        [DataRow(null,null)]
        public void ShouldNotCreateDataLensWithNullFactAndNullOntology(RDFOntologyFact input1, RDFOntology input2)
            => Assert.ThrowsException<RDFSemanticsException>(() => new RDFOntologyDataLens(input1, input2));

        [TestMethod]
        [DynamicData(nameof(DataStatusItemsTestSetupGivenDatalens))]
        public void ShouldCreateDataLensWithGivenFactAndGivenOntology(RDFOntologyFact input1, RDFOntology input2)
        {
            RDFOntologyDataLens ontologyDataLens = new RDFOntologyDataLens(input1, input2);

            Assert.IsNotNull(ontologyDataLens.Ontology);
            Assert.IsTrue(ontologyDataLens.OntologyFact.Value.Equals(input1.Value));
        }
    }
}
