using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Entity))]
public class Attack : MonoBehaviour
{

    public AtkCol UpCollider;
    public AtkCol DownCollider;
    public AtkCol RightCollider;
    public AtkCol LeftCollider;

    public Entity _entity;
    public Direction attackDir;
    private Move _move;
    private float timeAt = 0f;
    private float timeTot = 0.5f;
    public bool Attacking = false;

    void Start()
    {
        _move = _entity.MyMove;

        UpCollider.ent    = _entity;
        DownCollider.ent = _entity;
        RightCollider.ent = _entity;
        LeftCollider.ent = _entity;
    }
    
    void Update()
    {
        if (Attacking)
        {
            timeAt += Time.deltaTime;

            if(timeAt >= timeTot)
            {
                DeactivateCol(attackDir);
                timeAt = 0f;
                Attacking = false;
            }
        }
    }

    public void Hit()
    {
        if (Attacking) return;
        attackDir = _move.dir;
        ActivateCol();
        Attacking = true;
    }

    public void ActivateCol()
    {
        GameObject g = null;
        switch (attackDir)
        {
            case Direction.down:
                g = DownCollider.gameObject;
                break;
            case Direction.up:
                g = UpCollider.gameObject;
                break;
            case Direction.left:
                g = LeftCollider.gameObject;
                break;
            case Direction.right:
                g = RightCollider.gameObject;
                break;
        }
        g.SetActive(true);
        g.GetComponent<SpriteRenderer>().color = Color.red;
    }

    public void DeactivateCol(Direction dir)
    {
        GameObject g = null;
        switch (dir)
        {
            case Direction.down:
                g = DownCollider.gameObject;
                break;
            case Direction.up:
                g = UpCollider.gameObject;
                break;
            case Direction.left:
                g = LeftCollider.gameObject;
                break;
            case Direction.right:
                g = RightCollider.gameObject;
                break;
        }
        g.SetActive(false);
        g.GetComponent<SpriteRenderer>().color = Color.green;
    }
}
