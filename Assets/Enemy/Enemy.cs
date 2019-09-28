using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        Life = new Heart(3);
        Gold = new CoinBag(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
