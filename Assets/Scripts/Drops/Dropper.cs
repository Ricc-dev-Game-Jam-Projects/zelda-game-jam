using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public Bag MyOwner;
    public List<Dropable> drops;

    public void Drop()
    {
        GameObject g2 = new GameObject();
        g2.transform.position = this.transform.position;
        foreach (Dropable drop in drops)
        {
            GameObject g = GameObject.Instantiate(drop.gameObject, g2.transform, false);
            g.GetComponent<Dropable>().SetItem(MyOwner);
            //g.transform.position = this.transform.position;
        }
    }
}
