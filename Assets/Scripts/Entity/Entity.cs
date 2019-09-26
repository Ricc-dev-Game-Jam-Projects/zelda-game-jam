using Assets.Scripts.Drops;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    
    //protected bool CanBeDamaged { get; set; }
    protected bool isAlive { get; set; }
    protected Hearts Life { get; set; }
    protected Coins Gold { get; set; }

    public Entity()
    {
        isAlive = true;
        Life = new Hearts(5);
        Gold = new Coins(99);
    }
    

    public void TakeDamage(int damage)
    {
        if (Life.Damage(damage))
        {
            this.isAlive = false;
        }
        else
        {
            //knockback pra voce fazer riccardo
        }
    }

    public Move MyMove;
    public Attack MyAttack;

}
