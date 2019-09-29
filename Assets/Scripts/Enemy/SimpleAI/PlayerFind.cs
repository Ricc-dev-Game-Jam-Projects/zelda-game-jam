using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFind : MonoBehaviour
{
    public bool PlayerInside = false;
    public float Distance = 100f;

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
            Distance = 100f;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //Distance = 
    }
}
