using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Move MyMove;
    public Attack MyAttack;

    void Awake()
    {
        MyMove = GetComponent<Move>();
        MyAttack = GetComponent<Attack>();
    }
    
    void Update()
    {
        
    }
}
