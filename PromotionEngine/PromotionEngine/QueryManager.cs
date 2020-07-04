using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class QueryManager
    {
        private InputSetup input = new InputSetup();

        private Dictionary<string, int> inputQuery;

        public void InitializeInputQuery(string query)
        {
            try
            {
                this.inputQuery = new Dictionary<string, int>();
                foreach (var item in query.Split(','))
                {
                    var sku = item.Split('=');
                    this.inputQuery.Add(sku[0], Convert.ToInt32(sku[1]));
                }
            }
            catch (Exception ex)
            {
                throw new System.FormatException();
            }
        }

        public int GetFinalResultAfterAppliedPromotion()
        {
            int result = 0;
            foreach (var promotion in this.input.ActivePromotions)
            {
                bool isApplicable = true;
                foreach (var promoId in promotion.Ids)
                {
                    if (this.inputQuery[promoId.Key] < promoId.Value)
                    {
                        isApplicable = false;
                        break;
                    }
                }

                if (isApplicable)
                {
                    result += promotion.offerPrice;
                    foreach (var promoId in promotion.Ids)
                    {
                        this.inputQuery[promoId.Key] -= promoId.Value;
                    }

                }
            }

            foreach (var item in this.inputQuery)
            {
                if(item.Value > 0)
                {
                    result += this.input.SKU[item.Key] * item.Value;
                }
            }

            return result;
    
        }
    }
}
