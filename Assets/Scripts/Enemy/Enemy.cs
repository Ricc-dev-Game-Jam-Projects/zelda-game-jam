using System;
using UnityEngine;

public class Enemy : Entity
{
    //Life
    //Gold
    //public GameObject MyRoot;
    public Dropper dropper;
    public event Action OnTakeDamageEvent;
    public GameObject MyRoot;
    public Dropable item;

    void Start()
    {
        Life = new Heart(3);
        Gold = new CoinBag(0);

        dropper.MyOwner = new Bag();
        dropper.MyOwner.gold = new CoinBag(Gold.CoinValue);
    }

    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage);
        OnTakeDamageEvent?.Invoke();
    }

    public override void Die()
    {
        dropper.Drop();
        isAlive = false;
        Destroy(MyRoot, .5f);
    }
}
