using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkCol : MonoBehaviour
{
    public Entity ent;

    public void OnAtkEnter(Entity enemy, Entity atker)
    {
        if (this.ent == enemy) return;

        enemy.TakeDamage(atker.Damage);
        gameObject.SetActive(false);
        Debug.Log("Attacked: " + enemy.name + " HP: " + enemy.Life.LifePoints);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Entity ent2;
        ent2 = collision.gameObject.GetComponent<Player>();
        if (ent2 != null)
        {
            OnAtkEnter(ent2, this.ent);
            return;
        }
        ent2 = collision.gameObject.GetComponent<Enemy>();
        if (ent2 != null && !ent2.isAlive)
        {
            OnAtkEnter(ent2, this.ent);
            return;
        }
        Destructable destrc;
        destrc = collision.gameObject.GetComponent<Destructable>();
        if(destrc != null)
        {
            destrc.OnDestructed();
        }
    }
}
