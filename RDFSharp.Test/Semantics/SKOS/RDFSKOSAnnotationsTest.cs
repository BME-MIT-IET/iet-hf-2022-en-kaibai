using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    public class RDFSKOSAnnotationsTest
    {
        #region Tests
        [TestMethod]
        public void ShouldCreateEmptyRDFOntologyAnnotations()
        {
            RDFSKOSAnnotations annotations = new RDFSKOSAnnotations();

            //check whether the instance and attributes created
            Assert.IsNotNull(annotations);
            Assert.IsNotNull(annotations.AltLabel);
            Assert.IsNotNull(annotations.AltLabel.Entries);
            Assert.IsNotNull(annotations.ChangeNote);
            Assert.IsNotNull(annotations.ChangeNote.Entries);
            Assert.IsNotNull(annotations.Definition);
            Assert.IsNotNull(annotations.Definition.Entries);
            Assert.IsNotNull(annotations.EditorialNote);
            Assert.IsNotNull(annotations.EditorialNote.Entries);
            Assert.IsNotNull(annotations.Example);
            Assert.IsNotNull(annotations.Example.Entries);
            Assert.IsNotNull(annotations.HiddenLabel);
            Assert.IsNotNull(annotations.HiddenLabel.Entries);
            Assert.IsNotNull(annotations.HistoryNote);
            Assert.IsNotNull(annotations.HistoryNote.Entries);
            Assert.IsNotNull(annotations.Note);
            Assert.IsNotNull(annotations.Note.Entries);
            Assert.IsNotNull(annotations.PrefLabel);
            Assert.IsNotNull(annotations.PrefLabel.Entries);
            Assert.IsNotNull(annotations.ScopeNote);
            Assert.IsNotNull(annotations.ScopeNote.Entries);

            //check whether the number of insid attributes'List should be 0
            //and check whether the type of ontology toxnomy is 'Annotation'
            Assert.IsTrue(annotations.AltLabel.EntriesCount==0);
            Assert.IsTrue(annotations.AltLabel.Category== RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.ChangeNote.EntriesCount==0);
            Assert.IsTrue(annotations.ChangeNote.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.Definition.EntriesCount==0);
            Assert.IsTrue(annotations.Definition.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.EditorialNote.EntriesCount==0);
            Assert.IsTrue(annotations.EditorialNote.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.Example.EntriesCount==0);
            Assert.IsTrue(annotations.Example.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.HiddenLabel.EntriesCount==0);
            Assert.IsTrue(annotations.HiddenLabel.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.HistoryNote.EntriesCount==0);
            Assert.IsTrue(annotations.HistoryNote.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.Note.EntriesCount==0);
            Assert.IsTrue(annotations.Note.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.PrefLabel.EntriesCount == 0);
            Assert.IsTrue(annotations.PrefLabel.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);
            Assert.IsTrue(annotations.ScopeNote.EntriesCount == 0);
            Assert.IsTrue(annotations.ScopeNote.Category == RDFSemanticsEnums.RDFOntologyTaxonomyCategory.Annotation);

            //check whether the annotations accept exceptionally Duplicates
            Assert.IsFalse(annotations.AltLabel.AcceptDuplicates);
            Assert.IsFalse(annotations.ChangeNote.AcceptDuplicates);
            Assert.IsFalse(annotations.Definition.AcceptDuplicates);
            Assert.IsFalse(annotations.EditorialNote.AcceptDuplicates);
            Assert.IsFalse(annotations.Example.AcceptDuplicates);
            Assert.IsFalse(annotations.HiddenLabel.AcceptDuplicates);
            Assert.IsFalse(annotations.HistoryNote.AcceptDuplicates);
            Assert.IsFalse(annotations.Note.AcceptDuplicates);
            Assert.IsFalse(annotations.PrefLabel.AcceptDuplicates);
            Assert.IsFalse(annotations.ScopeNote.AcceptDuplicates);
        }
        #endregion
    }
}
