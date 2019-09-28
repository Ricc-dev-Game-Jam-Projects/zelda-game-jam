using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetInfoView : MonoBehaviour
{
    private Player player;

    public TextMeshProUGUI coinsText;
    public List<HeartPart> Hearts;
    public GameObject HeartRoot;
    public GameObject HeartPrefab;

    void Start()
    {
        player = FindObjectOfType<Player>();

        foreach(LifePoints lf in player.Life.LifePoints)
        {
            GameObject g = Instantiate(HeartPrefab, HeartRoot.transform, false);
            HeartPart hp = g.GetComponent<HeartPart>();
            Hearts.Add(hp);
        }
    }
    
    void Update()
    {
        if(player != null)
        {
            coinsText.text = "x" + player.Gold.CoinValue;

            int c = 0;
            foreach(LifePoints lf in player.Life.LifePoints)
            {
                if (player.Life.LifePoints.Count != Hearts.Count)
                {
                    UpdateHeartList();
                    break;
                }
                Hearts[c].ChangeSpriteByValue(lf.LifePoint);
                c++;
            }
        }
    }

    public void UpdateHeartList()
    {
        GameObject g = Instantiate(HeartPrefab, HeartRoot.transform, false);
        HeartPart hp = g.GetComponent<HeartPart>();
        Hearts.Add(hp);
    }
}
