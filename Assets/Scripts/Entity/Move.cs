using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    right,
    left,
    up,
    down
}

[RequireComponent(typeof(Entity))]
public class Move : MonoBehaviour
{
    public float speed = 5f;
    public Direction dir;
    private Transform transf;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        transf = GetComponent<Transform>();
        dir = Direction.up;
    }

    public void MoveTo(Direction dir)
    {
        Vector3 movement = new Vector3(0.0f, 0.0f, 0.0f);
        if (dir == Direction.left)
        {
            transf.Translate(Vector3.left * Time.deltaTime * speed);
            this.dir = Direction.left;
            movement.x = 1f;
        }
        else if (dir == Direction.right)
        {
            transf.Translate(Vector3.right * Time.deltaTime * speed);
            this.dir = Direction.right;
            movement.x = -1f;
        }
        else if (dir == Direction.down)
        {
            transf.Translate(Vector3.down * Time.deltaTime * speed);
            this.dir = Direction.down;
            movement.y = 1f;
        }
        else if (dir == Direction.up)
        {
            transf.Translate(Vector3.up * Time.deltaTime * speed);
            this.dir = Direction.up;
            movement.y = -1f;
        }

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Magnitude", movement.magnitude);
    }
}
