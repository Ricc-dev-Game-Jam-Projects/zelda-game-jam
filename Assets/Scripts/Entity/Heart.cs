using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class LifePoints
{
    public float LifePoint;

    public LifePoints(float life)
    {
        LifePoint = life;
    }
}

public class Heart
{
    public float MaxLifePoints = 3f;
    public Queue<LifePoints> LifePoints = new Queue<LifePoints>();

    public Heart(float start)
    {
        for(int i = 0; i < start; i++)
        {
            LifePoints.Enqueue(new LifePoints(1f));
        }
        MaxLifePoints = 3;
    }

    public bool MaxLife()
    {
        float sum = 0;
        foreach(LifePoints f in LifePoints)
        {
            sum += f.LifePoint;
        }
        return sum != 3f;
    }

    public bool Dead()
    {
        float sum = 0;
        foreach (LifePoints f in LifePoints)
        {
            sum += f.LifePoint;
        }
        return sum == 0f;
    }

    public void Heal(float heal)
    {
        if (!MaxLife())
        {
            LifePoints lf = LifePoints.First(x => x.LifePoint + heal <= 1f);
            if (lf != null)
            {
                lf.LifePoint += heal;
                return;
            }
            lf = LifePoints.First(x => x.LifePoint != 1f);
            if(lf != null)
            {
                lf.LifePoint = 1f;
                return;
            }
        }
        
    }

    public bool Damage(float damage)
    {
        foreach(LifePoints lf in LifePoints)
        {
            if (damage == 0f) break;
            if (lf.LifePoint == 0f) continue;
            if(lf.LifePoint - damage == 0f)
            {
                lf.LifePoint = 0f;
                damage = 0f;
            } else if(lf.LifePoint - damage < 0f)
            {
                float sobra = damage - lf.LifePoint;
                damage -= sobra;
                lf.LifePoint = 0f;
            } else if(lf.LifePoint - damage > 0f)
            {
                lf.LifePoint -= damage;
                damage = 0f;
            }
        }
        return Dead();
    }
}
