using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Semantics.SKOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDFSharp.Test.Semantics.SKOS
{
    [TestClass]
    public class RDFSKOSOntologyTest
    {
        #region Tests

        [TestMethod]
        public void ShouldCreateEmptyRDFSKOSOntologyTest()
        {
            Assert.IsNotNull(RDFSKOSOntology.Instance);
            Assert.IsNotNull(RDFSKOSOntology.Instance.Data);
            Assert.IsNotNull(RDFSKOSOntology.Instance.Model);
            Assert.IsNotNull(RDFSKOSOntology.Instance.Annotations);

            Assert.AreEqual(RDFSKOSOntology.Instance.ToString(), "http://www.w3.org/2004/02/skos/core#");
        }
            #endregion
       }
}
