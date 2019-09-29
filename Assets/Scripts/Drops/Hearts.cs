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
    }
}
