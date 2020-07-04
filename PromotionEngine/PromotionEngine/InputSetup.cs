using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    public class InputSetup
    { 
        private bool isSkuInitialized = false;

        private bool isPromotionsInitialized = false;

        // it's made private to restrict SKU setup from this class
        private Dictionary<string, int> skusDetails;

        private List<ActivePromotion> activePromotions;

        public List<ActivePromotion> ActivePromotions { 
            get
            {
                return this.activePromotions;
            }
        }

        // This is just to get skusDetails so that from outside it can't be altered
        public Dictionary<string, int> SKU 
        { 
            get 
            {
                if(!isSkuInitialized)
                {
                    this.InitializeSku();
                }

                return this.skusDetails;
            }
        }

        private void InitializeActivePromotions()
        {
            this.activePromotions = new List<ActivePromotion>();

            this.activePromotions.Add(new ActivePromotion
            {
                Ids = new Dictionary<string, int>()
                {
                    {"A", 3}
                },

                offerPrice = 130
            });

            this.activePromotions.Add(new ActivePromotion
            {
                Ids = new Dictionary<string, int>()
                {
                    {"B",  2}
                },

                offerPrice = 45
            });

            this.activePromotions.Add(new ActivePromotion
            {
                Ids = new Dictionary<string, int>()
                {
                    {"C", 1},
                    {"D", 1},
                },
                offerPrice = 30
            });

            this.isPromotionsInitialized = true;
        }

        private void InitializeSku()
        {
            this.skusDetails = new Dictionary<string, int>();
            /*
              // This is to use in case, custom interaction is needed for input

             string skuId = "";
            do
            {
                Console.Write("\t\tEnter SKU Id : ");
                skuId = Console.ReadLine();
                Console.Write("\n\tWhats price of '{0}' SKU Id : ");
                
                this.skusDetails.Add(skuId, Convert.ToInt32(Console.ReadLine()));

                Console.Write("\n\n\t Do you want to add more Y/N : ");
                char continuationFlag = Console.ReadKey().KeyChar;

                if(continuationFlag != 'Y' || continuationFlag != 'y')
                {
                    break;
                }
            } while (true);
            */

            this.skusDetails.Add("A", 50);
            this.skusDetails.Add("B", 30);
            this.skusDetails.Add("C", 20);
            this.skusDetails.Add("D", 15);

            isSkuInitialized = true;
        }
    }
}
