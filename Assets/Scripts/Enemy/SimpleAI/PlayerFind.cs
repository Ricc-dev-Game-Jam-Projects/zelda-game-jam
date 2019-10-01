using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFind : MonoBehaviour
{
    public bool PlayerInside = false;
    public float Distance = 100f;
    public AttackAI attackAI;
    public Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null)
        {
            PlayerInside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Player>() != null)
        {
            PlayerInside = false;
            attackAI.CanAttack = false;
            Distance = 100f;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            this.player = player;
            float deltaX, deltaY;
            deltaX = other.gameObject.GetComponent<Transform>().position.x - transform.position.x;
            deltaY = other.gameObject.GetComponent<Transform>().position.y - transform.position.y;
            Distance = Mathf.Sqrt(Mathf.Pow(deltaX, 2) + Mathf.Pow(deltaY, 2));
            if(Distance <= 10f)
            {
                attackAI.CanAttack = true;
            }
        }
    }
}
