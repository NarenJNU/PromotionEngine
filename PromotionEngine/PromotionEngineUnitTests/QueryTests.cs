using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineUnitTests
{
    [TestClass]
    public class QueryTests
    {

        [TestMethod]
        public void PromotionEngine_InputQuery1_NoError()
        {
            string input = "A=5,B=5,C=1";
        }

        [TestMethod]
        public void PromotionEngine_InputQuery2_NoError()
        {
            string input = "A=1,B=1,C=1";
        }

        [TestMethod]
        public void PromotionEngine_InputQuery3_NoError()
        {
            string input = "A=3,B=5,C=1,D=1";
        }

    }
}
