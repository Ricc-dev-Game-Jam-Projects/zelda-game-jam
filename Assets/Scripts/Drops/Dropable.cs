using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Drops
{
    abstract class Dropable
    {
        protected float DropRating { get; set; }
        protected string SpritePath { get; set; }

        public abstract float IncreaseDropRating();
        public abstract float DecreaseDropRating(int parameter);
    }
}
