using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkCol : MonoBehaviour
{
    public Entity ent;

    public void OnAtkEnter(Entity enemy)
    {
        if (this.ent = enemy) return;

        Debug.Log("Attacked: " + enemy.name);
    }
}
