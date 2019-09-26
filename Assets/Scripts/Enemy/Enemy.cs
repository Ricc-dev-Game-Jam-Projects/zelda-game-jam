using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    //Life
    //Gold

    void Start()
    {
        Life = new Heart(3);
        Gold = new CoinBag(0);
    }

    void Update()
    {
        
    }

    public void Die()
    {

    }
}
