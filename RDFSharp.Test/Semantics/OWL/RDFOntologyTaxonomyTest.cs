using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Semantics.OWL;
using System.Collections.Generic;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyTaxonomyTest
    {
        static IEnumerable<object[]> DataStatusItemsTestSetupOntologyTaxonomy
        {
            get
            {
                return new List<object[]>
                {
                     new object[]{ RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation, false }
                };
            }
        }

        [TestMethod]
        [DynamicData(nameof(DataStatusItemsTestSetupOntologyTaxonomy))]
        public void ShouldCreateFullOntologyTaxonomy(RDFSemanticsEnums.RDFOntologyTaxonomyCategory input1, bool input2)
        {
            RDFOntologyTaxonomy ontologyTaxonomy = new RDFOntologyTaxonomy(input1, input2);

            Assert.IsNotNull(ontologyTaxonomy);
            Assert.IsTrue(ontologyTaxonomy.Category.Equals(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation));
            Assert.IsTrue(ontologyTaxonomy.EntriesCount.Equals(0));
            Assert.IsNotNull(ontologyTaxonomy.EntriesLookup);
            Assert.IsTrue(ontologyTaxonomy.AcceptDuplicates.Equals(false));
        }
    }
}
