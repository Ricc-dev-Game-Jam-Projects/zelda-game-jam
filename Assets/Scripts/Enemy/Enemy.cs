using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    //Life
    //Gold
    public GameObject MyRoot;
    public Dropper dropper;

    void Start()
    {
        Life = new Heart(3);
        Gold = new CoinBag(0);
    }

    public override void Die()
    {
        dropper.DropCoin(Gold.CoinValue);
        isAlive = false;
        Destroy(MyRoot, .5f);
    }
}
