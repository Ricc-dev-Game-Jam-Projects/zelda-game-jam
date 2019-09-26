using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Drops
{
    public abstract class Dropable
    {
        protected float DropRating { get; set; }
        protected string SpritePath { get; set; }
        public Dropable()
        {
            this.DropRating = 0.25f;
        }

        public abstract float IncreaseDropRating();
        public abstract float DecreaseDropRating(float parameter);
    }
}
