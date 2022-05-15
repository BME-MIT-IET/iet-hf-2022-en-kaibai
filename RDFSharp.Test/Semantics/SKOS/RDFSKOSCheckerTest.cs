using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
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
    internal class RDFSKOSCheckerTest
    {
        #region Tests
        [TestMethod]
        public void ShouldCheckBroaderRelation()
        {
            //add Broader,Narrower,Related relation to check Checker
            RDFResource resourceConceptScheme = new RDFResource("http://resourceConceptScheme.org/");
            RDFResource resourceBroader = new RDFResource("http://resourceBroader.org/");
            RDFResource resourceNarrower = new RDFResource("http://resourceNarrower.org/");

            RDFSKOSConceptScheme conceptscheme = new RDFSKOSConceptScheme(resourceConceptScheme);
            RDFSKOSConcept conceptbroader = new RDFSKOSConcept(resourceBroader);
            RDFSKOSConcept conceptnarrow = new RDFSKOSConcept(resourceNarrower);

            RDFSKOSRelations relations = new RDFSKOSRelations();

            //add taxonomy to entry
            /*RDFOntologyResource taxonomySubject = new RDFOntologyResource();
            taxonomySubject.Value = (RDFPatternMember)resourcesubject;
            RDFOntologyResource taxonomyObject = new RDFOntologyResource();
            taxonomyObject.Value = (RDFPatternMember)resourceobject;

            bool addEntry = relations.Broader.AddEntry(
                new RDFSharp.Semantics.OWL.RDFOntologyTaxonomyEntry(
                    taxonomySubject
                    , RDFVocabulary.SKOS.BROADER.ToRDFOntologyObjectProperty()
                    , taxonomyObject));
            Assert.IsTrue(addEntry);*/

            conceptscheme.AddBroaderRelation(conceptbroader,conceptnarrow);
            Assert.IsNotNull(conceptscheme.Relations.Broader);
            Assert.IsTrue(RDFSKOSChecker.CheckBroaderRelation(conceptscheme,conceptbroader,conceptnarrow));

            

        }

        #endregion
    }
}
