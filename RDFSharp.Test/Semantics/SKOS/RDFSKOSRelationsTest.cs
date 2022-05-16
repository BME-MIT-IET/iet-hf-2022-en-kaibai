using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Query;
using RDFSharp.Semantics.OWL;
using RDFSharp.Semantics.SKOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDFSharp.Test.Semantics.SKOS
{
    [TestClass]
    public class RDFSKOSRelationsTest
    {
        #region Tests
        [TestMethod]
        public void ShouldCreateEmptyRDFSKOSRelations(){

            RDFSKOSRelations relations = new RDFSKOSRelations();
            Assert.IsNotNull(relations);
            Assert.IsNotNull(relations.AltLabel);
            Assert.IsNotNull(relations.Broader);
            Assert.IsNotNull(relations.BroaderTransitive);
            Assert.IsNotNull(relations.BroadMatch);
            Assert.IsNotNull(relations.CloseMatch);
            Assert.IsNotNull(relations.ExactMatch);
            Assert.IsNotNull(relations.HiddenLabel);
            Assert.IsNotNull(relations.LabelRelation);
            Assert.IsNotNull(relations.PrefLabel);
        }

        [TestMethod]
        public void ShouldAddRelations()
        {
            RDFSKOSRelations relations = new RDFSKOSRelations();
            Assert.IsNotNull(relations);

            RDFOntologyTaxonomy taxonomy = new RDFOntologyTaxonomy(RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation, false);
            Assert.IsNotNull(taxonomy);
            Assert.AreEqual(taxonomy.Category,RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);

            RDFOntologyResource resourcesubject = new RDFOntologyResource();
            RDFOntologyResource resouceobject = new RDFOntologyResource();
            resourcesubject.Value = new RDFPatternMember();
            resouceobject.Value = new RDFPatternMember();
            RDFOntologyTaxonomyEntry entry = new RDFOntologyTaxonomyEntry(resourcesubject, RDFSharp.Model.RDFVocabulary.SKOS.NOTE.ToRDFOntologyAnnotationProperty(),resouceobject);
            Assert.IsNotNull(entry);
            Assert.AreEqual(entry.TaxonomySubject, resourcesubject);
            Assert.AreEqual(entry.TaxonomySubject, resourcesubject);
            relations.TopConcept.AddEntry(entry);
            Assert.AreEqual(((RDFOntologyTaxonomyEntry)entry).TaxonomySubject, resourcesubject);
            Assert.AreEqual(((RDFOntologyTaxonomyEntry)entry).TaxonomyObject, resouceobject);
            //check whether the added entry is same as the one we created
            relations.Broader.AddEntry(entry);
            Assert.AreEqual(((RDFOntologyTaxonomyEntry)relations.Broader.Entries.ElementAt(0)).TaxonomySubject, resourcesubject);
            Assert.AreEqual(((RDFOntologyTaxonomyEntry)relations.Broader.Entries.ElementAt(0)).TaxonomyObject, resouceobject);
        }

            #endregion
        }
}
