using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Semantics.OWL;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyDataMetadataTest
    {
        [TestMethod]
        public void ShouldCreateFullOntologyDataMetadata()
        {
            RDFOntologyDataMetadata ontologyDataMetadata = new RDFOntologyDataMetadata();

            Assert.IsNotNull(ontologyDataMetadata.ClassType);
            Assert.IsTrue(ontologyDataMetadata.ClassType.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Data));
            Assert.IsTrue(ontologyDataMetadata.ClassType.Entries.Count.Equals(0));
            Assert.IsNotNull(ontologyDataMetadata.ClassType.EntriesLookup);
            Assert.IsTrue(ontologyDataMetadata.ClassType.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyDataMetadata.SameAs);
            Assert.IsTrue(ontologyDataMetadata.SameAs.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Data));
            Assert.IsTrue(ontologyDataMetadata.SameAs.Entries.Count.Equals(0));
            Assert.IsNotNull(ontologyDataMetadata.SameAs.EntriesLookup);
            Assert.IsTrue(ontologyDataMetadata.SameAs.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyDataMetadata.DifferentFrom);
            Assert.IsTrue(ontologyDataMetadata.DifferentFrom.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Data));
            Assert.IsTrue(ontologyDataMetadata.DifferentFrom.Entries.Count.Equals(0));
            Assert.IsNotNull(ontologyDataMetadata.DifferentFrom.EntriesLookup);
            Assert.IsTrue(ontologyDataMetadata.DifferentFrom.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyDataMetadata.Assertions);
            Assert.IsTrue(ontologyDataMetadata.Assertions.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Data));
            Assert.IsTrue(ontologyDataMetadata.Assertions.Entries.Count.Equals(0));
            Assert.IsNotNull(ontologyDataMetadata.Assertions.EntriesLookup);
            Assert.IsTrue(ontologyDataMetadata.Assertions.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyDataMetadata.NegativeAssertions);
            Assert.IsTrue(ontologyDataMetadata.NegativeAssertions.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Data));
            Assert.IsTrue(ontologyDataMetadata.NegativeAssertions.Entries.Count.Equals(0));
            Assert.IsNotNull(ontologyDataMetadata.NegativeAssertions.EntriesLookup);
            Assert.IsTrue(ontologyDataMetadata.NegativeAssertions.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyDataMetadata.Member);
            Assert.IsTrue(ontologyDataMetadata.Member.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Data));
            Assert.IsTrue(ontologyDataMetadata.Member.Entries.Count.Equals(0));
            Assert.IsNotNull(ontologyDataMetadata.Member.EntriesLookup);
            Assert.IsTrue(ontologyDataMetadata.Member.AcceptDuplicates.Equals(false));

            Assert.IsNotNull(ontologyDataMetadata.MemberList);
            Assert.IsTrue(ontologyDataMetadata.MemberList.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Data));
            Assert.IsTrue(ontologyDataMetadata.MemberList.Entries.Count.Equals(0));
            Assert.IsNotNull(ontologyDataMetadata.MemberList.EntriesLookup);
            Assert.IsTrue(ontologyDataMetadata.MemberList.AcceptDuplicates.Equals(false));
        }
    }
}
