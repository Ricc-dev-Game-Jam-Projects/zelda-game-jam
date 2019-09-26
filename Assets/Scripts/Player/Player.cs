using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    

    void Awake()
    {
        MyMove = GetComponent<Move>();
        MyAttack = GetComponent<Attack>();
    }

    private void Start()
    {
        MyAttack._player = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetMouseButtonDown(0))
        {
            MyAttack.Hit();
        }
    }

    private void FixedUpdate()
    {
        if(!MyAttack.Attacking)
        {
            if (Input.GetKey(KeyCode.A))
            {
                MyMove.MoveTo(Direction.left);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                MyMove.MoveTo(Direction.right);
            }
            if (Input.GetKey(KeyCode.S))
            {
                MyMove.MoveTo(Direction.down);
            }
            else if (Input.GetKey(KeyCode.W))
            {
                MyMove.MoveTo(Direction.up);
            }
        }
    }
}
