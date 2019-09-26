using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Dropable : MonoBehaviour
{
    protected float DropRating { get; set; }
    protected string SpritePath { get; set; }
    public Dropable()
    {
        this.DropRating = 0.25f;
    }

    public virtual float IncreaseDropRating() { return 0f; }
    public virtual float DecreaseDropRating(float parameter) { return 0; }
    
}
