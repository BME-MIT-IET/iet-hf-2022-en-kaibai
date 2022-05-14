using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Semantics.OWL;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyDataLensTest
    {
        [TestMethod]
        [DataRow(null,null)]
        public void ShouldNotCreateDataLensWithNullFactAndNullOntology(RDFOntologyFact input1, RDFOntology input2)
            => Assert.ThrowsException<RDFSemanticsException>(() => new RDFOntologyDataLens(input1, input2));
    }
}
