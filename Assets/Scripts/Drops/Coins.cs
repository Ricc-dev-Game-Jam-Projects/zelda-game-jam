using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Coins : Dropable
{
    public int ActualCoinNumber;

    private void Start()
    {
        this.DropRating = 0.35f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Gold.AddCoin(ActualCoinNumber);
            Debug.Log("Player tem: " + player.Gold.CoinValue);
            Destroy(gameObject);
        }
    }
    
    public override float DecreaseDropRating(float parameter)
    {
        this.DropRating = DropRating - parameter;
        return this.DropRating;
    }

    public override float IncreaseDropRating()
    {
        if(ActualCoinNumber == 20)
        {
            this.DropRating = DropRating + 0.10f;
            return this.DropRating;
        }
        return this.DropRating;
    }
}
