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
    [TestClass]
    public class RDFSKOSCheckerTest
    {
        #region Tests

        RDFSKOSConceptScheme conceptscheme ;
        RDFSKOSConcept conceptbroader ;
        RDFSKOSConcept conceptnarrow ;
        RDFSKOSConcept conceptrelated;
        RDFSKOSConcept conceptnorelationyet;
        [TestInitialize] 
        public void Initialize()
        {
            //add Broader,Narrower,Related relation to check Checker
            RDFResource resourceConceptScheme = new RDFResource("http://resourceConceptScheme.org/");
            RDFResource resourceBroader = new RDFResource("http://resourceBroader.org/");
            RDFResource resourceNarrower = new RDFResource("http://resourceNarrower.org/");
            RDFResource resourceRelated = new RDFResource("http://resourceRelated.org/");
            RDFResource resourceNoRelationYet = new RDFResource("http://resourceNoRelationYet.org/");

            conceptscheme = new RDFSKOSConceptScheme(resourceConceptScheme);
            conceptbroader = new RDFSKOSConcept(resourceBroader);
            conceptnarrow = new RDFSKOSConcept(resourceNarrower);
            conceptrelated = new RDFSKOSConcept(resourceRelated);
            conceptnorelationyet = new RDFSKOSConcept(resourceNoRelationYet);
            //add relations into concpetscheme
            conceptscheme.AddBroaderRelation(conceptbroader, conceptnarrow);
            conceptscheme.AddNarrowerRelation(conceptnarrow, conceptbroader);
            conceptscheme.AddRelatedRelation(conceptbroader, conceptrelated);
            conceptscheme.AddRelatedRelation(conceptrelated, conceptbroader);
        }

        [TestMethod]
        public void ShouldCheckBroaderRelation()
        {
            //check whether the CheckBroaderRelation result in Broader, narrow, related, match relations 
            Assert.IsNotNull(conceptscheme.Relations.Broader);
            Assert.IsTrue(RDFSKOSChecker.CheckBroaderRelation(conceptscheme,conceptbroader,conceptnarrow));

            Assert.IsNotNull(conceptscheme.Relations.Related);
            Assert.IsFalse(RDFSKOSChecker.CheckBroaderRelation(conceptscheme, conceptbroader, conceptrelated));

            Assert.IsNotNull(conceptscheme.Relations.Narrower);
            Assert.IsFalse(RDFSKOSChecker.CheckBroaderRelation(conceptscheme, conceptnarrow, conceptbroader));

            Assert.IsTrue(RDFSKOSChecker.CheckBroaderRelation(conceptscheme, conceptbroader, conceptnorelationyet));
        }

        [TestMethod]
        public void ShouldCheckNarrowerRelation()
        {
            //check whether the CheckNarrowerRelation result in Broader, narrow, related, match relations 
            Assert.IsNotNull(conceptscheme.Relations.Broader);
            Assert.IsFalse(RDFSKOSChecker.CheckNarrowerRelation (conceptscheme, conceptbroader, conceptnarrow));

            Assert.IsNotNull(conceptscheme.Relations.Related);
            Assert.IsFalse(RDFSKOSChecker.CheckNarrowerRelation(conceptscheme, conceptbroader, conceptrelated));

            Assert.IsNotNull(conceptscheme.Relations.Narrower);
            Assert.IsTrue(RDFSKOSChecker.CheckNarrowerRelation(conceptscheme, conceptnarrow, conceptbroader));

            Assert.IsTrue(RDFSKOSChecker.CheckNarrowerRelation(conceptscheme, conceptbroader, conceptnorelationyet));

        }

        [TestMethod]
        public void ShouldCheckRelatedRelation()
        {
            //check whether the CheckRelatedRelation result in Broader, narrow, related, match relations 
            Assert.IsNotNull(conceptscheme.Relations.Broader);
            Assert.IsFalse(RDFSKOSChecker.CheckRelatedRelation(conceptscheme, conceptbroader, conceptnarrow));

            Assert.IsNotNull(conceptscheme.Relations.Related);
            Assert.IsTrue(RDFSKOSChecker.CheckRelatedRelation(conceptscheme, conceptbroader, conceptrelated));

            Assert.IsNotNull(conceptscheme.Relations.Narrower);
            Assert.IsFalse(RDFSKOSChecker.CheckRelatedRelation(conceptscheme, conceptnarrow, conceptbroader));

            Assert.IsTrue(RDFSKOSChecker.CheckNarrowerRelation(conceptscheme, conceptbroader, conceptnorelationyet));

        }

        [TestMethod]
        public void ShouldCheckCloseOrExactMatchRelation()
        {
            //check whether the CheckNarrowerRelation result in Broader, narrow, related, match relations 
            Assert.IsNotNull(conceptscheme.Relations.Broader);
            Assert.IsFalse(RDFSKOSChecker.CheckCloseOrExactMatchRelation(conceptscheme, conceptbroader, conceptnarrow));

            Assert.IsNotNull(conceptscheme.Relations.Related);
            Assert.IsTrue(RDFSKOSChecker.CheckCloseOrExactMatchRelation(conceptscheme, conceptbroader, conceptrelated));

            Assert.IsNotNull(conceptscheme.Relations.Narrower);
            Assert.IsFalse(RDFSKOSChecker.CheckCloseOrExactMatchRelation(conceptscheme, conceptnarrow, conceptbroader));

            Assert.IsTrue(RDFSKOSChecker.CheckNarrowerRelation(conceptscheme, conceptbroader, conceptnorelationyet));

        }
        #endregion
    }
}
