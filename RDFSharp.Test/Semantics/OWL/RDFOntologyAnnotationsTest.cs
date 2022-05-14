using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Semantics.OWL;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyAnnotationsTest
    {
        #region Tests
        [TestMethod]
        public void ShouldCreateEmptyRDFOntologyAnnotations()
        {
            RDFOntologyAnnotations ontologyAnnotations = new RDFOntologyAnnotations();

            Assert.IsNotNull(ontologyAnnotations.VersionInfo);
            Assert.IsTrue(ontologyAnnotations.VersionInfo.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.VersionIRI);
            Assert.IsTrue(ontologyAnnotations.VersionIRI.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.Comment);
            Assert.IsTrue(ontologyAnnotations.Comment.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.Label);
            Assert.IsTrue(ontologyAnnotations.Label.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.SeeAlso);
            Assert.IsTrue(ontologyAnnotations.SeeAlso.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.IsDefinedBy);
            Assert.IsTrue(ontologyAnnotations.IsDefinedBy.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.PriorVersion);
            Assert.IsTrue(ontologyAnnotations.PriorVersion.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.BackwardCompatibleWith);
            Assert.IsTrue(ontologyAnnotations.BackwardCompatibleWith.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.IncompatibleWith);
            Assert.IsTrue(ontologyAnnotations.IncompatibleWith.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.Imports);
            Assert.IsTrue(ontologyAnnotations.Imports.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.CustomAnnotations);
            Assert.IsTrue(ontologyAnnotations.CustomAnnotations.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyAnnotations.AxiomAnnotations);
            Assert.IsTrue(ontologyAnnotations.AxiomAnnotations.AcceptDuplicates.Equals(false));
        }
        #endregion
    }
}
