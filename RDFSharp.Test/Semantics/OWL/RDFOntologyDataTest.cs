using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
using RDFSharp.Semantics.OWL;
using System.Collections.Generic;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyDataTest
    {
        static IEnumerable<object[]> DataStatusItemsTestSetupGivenFact
        {
            get
            {
                return new List<object[]>
                {
                     new object[]{ new RDFOntologyFact(new RDFResource("http://hello/world#hi")) }
                };
            }
        }

        [TestMethod]
        public void ShouldCreateEmptyOntologyData()
        {
            RDFOntologyData ontologyData = new RDFOntologyData();

            Assert.IsNotNull(ontologyData.Facts);
            Assert.IsNotNull(ontologyData.Literals);
            Assert.IsNotNull(ontologyData.Annotations);
            Assert.IsNotNull(ontologyData.Relations);
        }

        [TestMethod]
        [DataRow(null)]
        public void ShouldNotAddNullFact(RDFOntologyFact input1)
        {
            RDFOntologyData ontologyData = new RDFOntologyData();

            ontologyData.AddFact(input1);

            Assert.IsTrue(ontologyData.Facts.Count.Equals(0));
        }

        [TestMethod]
        [DynamicData(nameof(DataStatusItemsTestSetupGivenFact))]
        public void ShouldAddGivenFact(RDFOntologyFact input1)
        {
            RDFOntologyData ontologyData = new RDFOntologyData();

            ontologyData.AddFact(input1);

            Assert.IsTrue(ontologyData.Facts.Count.Equals(1));
        }

        [TestMethod]
        [DataRow(null)]
        public void ShouldAddNullLiteral(RDFOntologyLiteral input1)
        {
            RDFOntologyData ontologyData = new RDFOntologyData();

            ontologyData.AddLiteral(input1);

            Assert.IsTrue(ontologyData.Literals.Count.Equals(0));
        }
    }
}
