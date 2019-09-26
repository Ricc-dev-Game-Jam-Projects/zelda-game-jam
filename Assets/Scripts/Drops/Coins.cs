using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Drops
{
    public class Coins : Dropable
    {
        private int MaximumCoins { get; set; }
        private int ActualCoinNumber { get; set; }

        public Coins(int max)
        {
            this.DropRating = 0.35f;
            this.ActualCoinNumber = 0;
            this.MaximumCoins = max;
        }


        public override float DecreaseDropRating(float parameter)
        {
            this.DropRating = DropRating - parameter;
            return this.DropRating;
            
        }

        public override float IncreaseDropRating()
        {
            if(MaximumCoins - ActualCoinNumber == 20)
            {
                this.DropRating = DropRating + 0.10f;
                return this.DropRating;
            }
            return this.DropRating;
        }
    }
}
