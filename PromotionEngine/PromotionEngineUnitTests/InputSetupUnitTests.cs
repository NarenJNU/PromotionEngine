using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineUnitTests
{
    [TestClass]
    public class InputSetupUnitTests
    {

        private InputSetup testInputObj = new InputSetup();

        [TestMethod]
        public void PromotionEngine_VerifyActivePromotion_Innitialized_NoError()
        {
           var initializeActivePromotion = this.testInputObj.ActivePromotions;
           Assert.IsNotNull(this.testInputObj.ActivePromotions);
        }

        [TestMethod]
        public void PromotionEngine_VerifySkuPromotion_Innitialized_NoError()
        {
            var initializeActivePromotion = this.testInputObj.SKU;
            Assert.IsNotNull(this.testInputObj.SKU);
        }



    }
}
