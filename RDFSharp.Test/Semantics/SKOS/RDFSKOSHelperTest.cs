using Microsoft.VisualStudio.TestTools.UnitTesting;
using RDFSharp.Model;
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
    public class RDFSKOSHelperTest
    {
            #region Tests

            RDFSKOSConceptScheme conceptscheme;
            RDFSKOSConcept conceptbroader;
            RDFSKOSConcept conceptnarrow;
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
            public void ShouldAddTopConceptRelation()
            {
                    RDFResource resource = new RDFResource("http://scheme.org/");
                    RDFSKOSConceptScheme scheme = new RDFSKOSConceptScheme(resource);
                    Assert.IsNotNull(scheme);
                    Assert.AreEqual(scheme.Value.ToString(), "http://scheme.org/");

                    RDFResource resourcea = new RDFResource("http://resourcea.org/");
                    RDFSKOSConcept concepta= new RDFSKOSConcept(resourcea);
                    Assert.IsNotNull (concepta);

                    //add conepta to top relation of scheme
                    RDFSKOSHelper.AddTopConceptRelation(scheme,concepta);
                    Assert.AreEqual(((RDFOntologyTaxonomyEntry)scheme.Relations.TopConcept.Entries.First()).TaxonomySubject, (RDFOntologyResource)scheme);
                    Assert.AreEqual(((RDFOntologyTaxonomyEntry)scheme.Relations.TopConcept.Entries.First()).TaxonomyPredicate.ToString(), RDFVocabulary.SKOS.HAS_TOP_CONCEPT.ToRDFOntologyObjectProperty().ToString());
                    Assert.AreEqual(((RDFOntologyTaxonomyEntry)scheme.Relations.TopConcept.Entries.First()).TaxonomyObject, (RDFOntologyResource)concepta);
            }
            #endregion
        }
    }
