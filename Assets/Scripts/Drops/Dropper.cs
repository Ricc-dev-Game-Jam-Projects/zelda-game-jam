using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public GameObject Hearts;
    public GameObject Coins;

    public void DropCoin(int coins)
    {
        GameObject g = Instantiate(Coins);
        g.transform.position = this.transform.position;
        g.GetComponent<Coins>().ActualCoinNumber = coins;
    }
}
