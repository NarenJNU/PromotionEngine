using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineUnitTests
{
    [TestClass]
    public class QueryTests
    {
        private QueryManager queryManager = new QueryManager();

        [TestMethod]
        public void PromotionEngine_InputQuery1_NoError()
        {
            string input = "B=1,C=1";
            queryManager.InitializeInputQuery(input);
            int res = queryManager.GetFinalResultAfterAppliedPromotion();
            Assert.AreEqual(res, 50);
        }

        [TestMethod]
        public void PromotionEngine_InputQuery2_NoError()
        {
            string input = "A=1,B=1,C=1";
            queryManager.InitializeInputQuery(input);
            int res = queryManager.GetFinalResultAfterAppliedPromotion();
            Assert.AreEqual(res, 100);
        }
    }
}
