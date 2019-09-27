using System;
using UnityEngine;

public class Enemy : Entity
{
    //Life
    //Gold
    //public GameObject MyRoot;
    public Dropper dropper;
    public event Action OnTakeDamageEvent;

    void Start()
    {
        Life = new Heart(3);
        Gold = new CoinBag(0);
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        OnTakeDamageEvent?.Invoke();
    }

    public override void Die()
    {
        dropper.DropCoin(Gold.CoinValue);
        isAlive = false;
        Destroy(gameObject, .5f);
    }
}
