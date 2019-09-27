using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetInfoView : MonoBehaviour
{
    private Player player;

    public TextMeshProUGUI coinsText;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    
    void Update()
    {
        if(player != null)
        {
            coinsText.text = "x" + player.Gold.CoinValue;
        }
    }
}
