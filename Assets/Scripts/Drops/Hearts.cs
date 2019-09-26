using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Drops
{
   public class Hearts : Dropable
    {
        private int MaxLifePoints { get; set; }
        private int LifePoints { get; set; }

        public Hearts(int points)
        {
            this.LifePoints = points;
        }

        public override float DecreaseDropRating(float parameter)
        {
            this.DropRating = this.DropRating - parameter;
            return this.DropRating;
        }

        public override float IncreaseDropRating()
        {
            if(this.LifePoints - 2 == 0)
            {
                this.DropRating = this.DropRating * 2f;
                return this.DropRating;
            }
            return this.DropRating;
        }


    }
}
