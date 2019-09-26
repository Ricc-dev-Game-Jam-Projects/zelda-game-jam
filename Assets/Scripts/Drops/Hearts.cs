using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Drops
{
    class Hearts : Dropable
    {
        public override float DecreaseDropRating(int parameter)
        {
            this.DropRating = this.DropRating - parameter;
            return this.DropRating;
        }

        public override float IncreaseDropRating()
        {
            throw new NotImplementedException();
        }
    }
}
