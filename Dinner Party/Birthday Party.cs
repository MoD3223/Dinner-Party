using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner_Party
{
    class Birthday_Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }

        public Birthday_Party(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                {
                    return CakeWriting.Length;
                }
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                return 8;
            }
            else
            {
                return 16;
            }
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
            {
                return 20;
            }
            else
            {
                return 40;
            }
        }

        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        private decimal CalculateCostOfDecorations()
        {
            decimal costofdecorations;
            if (FancyDecorations)
            {
                costofdecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costofdecorations = (NumberOfPeople * 7.50M) + 30M;
            }
            return costofdecorations;
        }


        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                {
                    cakeCost = 40M + ActualLength * .25M;
                }
                else
                {
                    cakeCost = 75M + ActualLength * .25M;
                }
                return totalCost + cakeCost;
            }
        }







    }
}
