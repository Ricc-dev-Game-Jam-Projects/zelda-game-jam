using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartPart : MonoBehaviour
{
    public Sprite HeartFull;
    public Sprite Heart3_4;
    public Sprite HeartHalf;
    public Sprite HeartQuarter;
    public Sprite HeartNull;

    private Image render;

    private void Start()
    {
        render = GetComponent<Image>();
    }

    public void ChangeSpriteByValue(float life)
    {
        if(life >= 1f)
        {
            render.sprite = HeartFull;
        } else if(life >= 0.75f)
        {
            render.sprite = Heart3_4;
        } else if(life >= 0.5f)
        {
            render.sprite = HeartHalf;
        }else if(life >= 0.25)
        {
            render.sprite = HeartQuarter;
        } else if(life == 0f)
        {
            render.sprite = HeartNull;
        }
    }
}
