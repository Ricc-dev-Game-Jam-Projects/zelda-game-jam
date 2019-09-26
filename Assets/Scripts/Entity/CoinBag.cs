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
        CoinMax = 99;
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