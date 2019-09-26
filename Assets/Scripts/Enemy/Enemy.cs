using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    //Life
    //Gold

    void Start()
    {
        
    }

    void Update()
    {
        if(Life <= 0)
        {
            Die();
        }
    }

    public void Die()
    {

    }
}
