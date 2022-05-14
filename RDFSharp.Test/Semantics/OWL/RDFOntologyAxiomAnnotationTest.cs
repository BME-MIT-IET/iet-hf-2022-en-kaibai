using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
using RDFSharp.Semantics.OWL;
using System.Collections.Generic;

namespace RDFSharp.Test.Semantics.OWL
{
    [TestClass]
    public class RDFOntologyAxiomAnnotationTest
    {
        [TestMethod]
        [DataRow(null,null)]
        public void ShouldNotCreateAxiomAnnotationDueToNullPropertyAndNullLiteral(RDFOntologyProperty input1, RDFOntologyLiteral input2)
            => Assert.ThrowsException<RDFSemanticsException>(() => new RDFOntologyAxiomAnnotation(input1, input2));
    }
}
