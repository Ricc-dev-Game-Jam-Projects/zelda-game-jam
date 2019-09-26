using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class CoinBag
{
    public int CoinValue;
    public int CoinMax;

    public CoinBag(int coins)
    {
        CoinValue = coins;
    }

    public bool AddCoin(int coins)
    {
        if(CoinValue + coins > CoinMax)
        {
            return false;
        }
        CoinValue += coins;
        return true;
    }

}