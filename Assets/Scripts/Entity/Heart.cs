using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Heart
{
    public float MaxLifePoints;
    public float LifePoints;

    public Heart(float start)
    {
        LifePoints = start;
    }

    public void Heal(float heal)
    {
        if (LifePoints + heal > MaxLifePoints)
        {
            LifePoints = MaxLifePoints;
        }
        else
        {
            LifePoints += heal;
        }
    }

    public bool Damage(float damage)
    {
        if (LifePoints - damage < 0)
        {
            LifePoints = 0;
            return true;
        }
        else
        {
            LifePoints -= damage;
            return false;
        }
    }
}
