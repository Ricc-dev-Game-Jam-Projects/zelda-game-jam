using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetInfoView : MonoBehaviour
{
    private Player player;

    public TextMeshProUGUI coinsText;
    public List<HeartPart> Hearts;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    
    void Update()
    {
        if(player != null)
        {
            coinsText.text = "x" + player.Gold.CoinValue;

            int c = 0;
            foreach(LifePoints lf in player.Life.LifePoints)
            {
                Hearts[c].ChangeSpriteByValue(lf.LifePoint);
                c++;
            }
            //if(floatPart != 0f)
            //{
            //    if (i == intPart) i = Hearts.Count - 1;
            //    Hearts[i].ChangeSpriteByValue(floatPart);
            //}
        }
    }
}
