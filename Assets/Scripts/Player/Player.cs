using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Entity
{
    private float newLife = 0f;

    public float AddLife = 0f;
    public bool HasWeapon = false;

    void Awake()
    {
        MyMove = GetComponent<Move>();
        MyAttack = GetComponent<Attack>();
    }

    private void Start()
    {
        MyAttack._entity = this;
        Life = new Heart(3);
        Gold = new CoinBag(0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) || Input.GetMouseButtonDown(0))
        {
            if(HasWeapon) MyAttack.Hit();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            TakeDamage(Damage);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            AddNewLife(AddLife);
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

    public void AddNewLife(float big)
    {
        float tmp = 0f;
        newLife += big;
        if(newLife >= 1f)
        {
            tmp = newLife - 1f;
            Life.AddHeart();
            newLife = tmp;
        }
    }

    public override void Die()
    {
        SceneManager.LoadScene(1);
    }
}
