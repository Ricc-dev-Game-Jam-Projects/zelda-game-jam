using Assets.Scripts.Drops;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public bool isAlive;
    public Heart Life;
    public CoinBag Gold;

    public Move MyMove;
    public Attack MyAttack;

    private void Start()
    {
        isAlive = true;
        Life = new Heart(3);
        Gold = new CoinBag(0);
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
}
