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
        Life = new Heart(3);
        Gold = new CoinBag(0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            MyAttack.Hit();
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            MyMove.MoveTo(Direction.left);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MyMove.MoveTo(Direction.right);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MyMove.MoveTo(Direction.down);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            MyMove.MoveTo(Direction.up);
        }
    }
}
