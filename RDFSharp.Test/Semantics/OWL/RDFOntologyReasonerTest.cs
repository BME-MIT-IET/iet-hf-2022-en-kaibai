using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
using RDFSharp.Semantics.OWL;
using RDFSharp.Query;
using System.Collections.Generic;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyReasonerTest
    {
        #region Tests
        [TestMethod]
        public void ShouldCreateNamedEmptyOntology()
        {
            RDFOntologyReasoner Reasoner = new RDFOntologyReasoner();

            Assert.IsNotNull(Reasoner);
            Assert.IsNotNull(Reasoner.StandardRules);
            Assert.IsNotNull(Reasoner.CustomRules);

        }

        [TestMethod]
        [DataRow(1)]
        public void AddStandardRuleNullResource(RDFSemanticsEnums.RDFOntologyStandardReasonerRule standardRule)
        {
            RDFOntologyReasoner Reasoner = new RDFOntologyReasoner();
            Assert.IsNotNull(Reasoner);
            Reasoner.AddStandardRule(standardRule);
            Assert.IsTrue(Reasoner.StandardRules.Contains(standardRule));
        }
        #endregion
    }
}
