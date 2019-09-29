using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Coins : Dropable
{
    public int ActualCoinNumber;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Gold.AddCoin(ActualCoinNumber);
            Debug.Log("Player has: " + player.Gold.CoinValue);
            Destroy(root);
        }
    }

    public override void SetItem(Bag Owner)
    {
        if(Owner.gold != null)
        {
            ActualCoinNumber = Owner.gold.CoinValue;
            Debug.Log("Coins: " + Owner.gold.CoinValue);
        }
    }
}
