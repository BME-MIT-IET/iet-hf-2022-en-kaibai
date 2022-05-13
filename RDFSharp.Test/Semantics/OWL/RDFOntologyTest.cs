using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
using RDFSharp.Semantics.OWL;
using System.Collections.Generic;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyTest
    {
        static IEnumerable<object[]> DataStatusItemsTestSetupEmptyOntology
        {
            get
            {
                return new List<object[]>
                {
                     new object[]{ new RDFResource("http://hello/world#hi") }
                };
            }
        }

        static IEnumerable<object[]> DataStatusItemsTestSetupGivenItemOntology
        {
            get
            {
                return new List<object[]>
                {
                    new object[]{ new RDFResource("http://hello/world#hi"), new RDFOntologyModel(), new RDFOntologyData(), new RDFOntologyAnnotations() }
                };
            }
        }

        static IEnumerable<object[]> DataStatusItemsTestSetupGivenNullItemOntology
        {
            get
            {
                return new List<object[]>
                {
                    new object[]{ new RDFResource("http://hello/world#hi"), null, null, null }
                };
            }
        }

        #region Tests
        [TestMethod]
        [DynamicData(nameof(DataStatusItemsTestSetupEmptyOntology))]
        public void ShouldCreateNamedEmptyOntology(RDFResource input)
        {
            RDFOntology ontology = new RDFOntology(input);

            Assert.IsNotNull(ontology);
            Assert.IsTrue(ontology.Value.ToString().Equals(input.ToString()));
            Assert.IsNotNull(ontology.Model);
            Assert.IsNotNull(ontology.Data);
            Assert.IsNotNull(ontology.Annotations);
        }

        [TestMethod]
        [DataRow(null)]
        public void ShouldNotCreateOntologyDueToNullResource(RDFResource input)
            => Assert.ThrowsException<RDFSemanticsException>(() => new RDFOntology(input));

        [TestMethod]
        [DynamicData(nameof(DataStatusItemsTestSetupGivenItemOntology))]
        public void ShouldCreateNamedGivenItemOntology(RDFResource input, RDFOntologyModel input2, RDFOntologyData input3, RDFOntologyAnnotations input4)
        {
            RDFOntology ontology = new RDFOntology(input, input2, input3, input4);

            Assert.IsNotNull(ontology);
            Assert.IsTrue(ontology.Value.ToString().Equals(input.ToString()));
            Assert.IsTrue(ontology.Model.ClassModel.Relations.SubClassOf.Category.Equals(input2.ClassModel.Relations.SubClassOf.Category));
            Assert.IsTrue(ontology.Data.FactsCount.Equals(input3.FactsCount));
            Assert.IsTrue(ontology.Annotations.VersionInfo.Category.Equals(input4.VersionInfo.Category));
        }

        [TestMethod]
        [DynamicData(nameof(DataStatusItemsTestSetupGivenNullItemOntology))]
        public void ShouldCreateNameGivenNullItemOntology(RDFResource input, RDFOntologyModel input2, RDFOntologyData input3, RDFOntologyAnnotations input4)
        {
            RDFOntology ontology = new RDFOntology(input);

            Assert.IsNotNull(ontology);
            Assert.IsTrue(ontology.Value.ToString().Equals(input.ToString()));
            Assert.IsNotNull(ontology.Model);
            Assert.IsNotNull(ontology.Data);
            Assert.IsNotNull(ontology.Annotations);
        }

        #endregion
    }
}
