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

    void Start()
    {
        transf = GetComponent<Transform>();
        dir = Direction.up;
    }

    public void MoveTo(Direction dir)
    {
        if (dir == Direction.left)
        {
            transf.Translate(Vector3.left * Time.deltaTime * speed);
            this.dir = Direction.left;
        }
        else if (dir == Direction.right)
        {
            transf.Translate(Vector3.right * Time.deltaTime * speed);
            this.dir = Direction.right;
        }
        else if (dir == Direction.down)
        {
            transf.Translate(Vector3.down * Time.deltaTime * speed);
            this.dir = Direction.down;
        }
        else if (dir == Direction.up)
        {
            transf.Translate(Vector3.up * Time.deltaTime * speed);
            this.dir = Direction.up;
        }
    }
}
