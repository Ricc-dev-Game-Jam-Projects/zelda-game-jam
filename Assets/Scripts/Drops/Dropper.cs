using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    public Bag MyOwner;
    public List<Dropable> drops;
    public GameObject MyFather;

    public void Drop()
    {
        GameObject g2 = new GameObject();
        g2.transform.position = MyFather.transform.position;
        foreach (Dropable drop in drops)
        {
            GameObject g = GameObject.Instantiate(drop.gameObject, g2.transform, false);
            g.GetComponent<Dropable>().SetItem(MyOwner);
            g.GetComponent<Dropable>().root = g2;
            g.GetComponent<Transform>().localPosition = Vector3.zero;
            //g.transform.position = this.transform.position;
        }
    }

    public void Drop(int itemPos)
    {
        GameObject g2 = new GameObject();
        g2.transform.position = MyFather.transform.position;
        Dropable drop = drops[itemPos];
        GameObject g = GameObject.Instantiate(drop.gameObject, g2.transform, false);
        g.GetComponent<Dropable>().SetItem(MyOwner);
        g.GetComponent<Dropable>().root = g2;
        g.GetComponent<Transform>().localPosition = Vector3.zero;
        Debug.Log("Dropped: " + MyFather.name);
    }
}
