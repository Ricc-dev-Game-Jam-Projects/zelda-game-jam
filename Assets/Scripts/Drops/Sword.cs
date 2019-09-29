using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Dropable
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.HasWeapon = true;
            Debug.Log("Player got a sword.");
            Destroy(root);
        }
    }
}
