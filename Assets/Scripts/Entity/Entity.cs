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
    public float Damage = 0.25f;

    private void Start()
    {
        isAlive = true;
        Life = new Heart(3);
        Gold = new CoinBag(0);
    }
    
    public virtual void TakeDamage(float damage)
    {
        if (Life.Damage(damage))
        {
            this.isAlive = false;
            Die();
        }
    }

    public virtual void Die()
    {

    }
}
