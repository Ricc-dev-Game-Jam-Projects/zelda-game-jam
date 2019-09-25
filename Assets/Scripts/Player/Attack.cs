using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Player))]
public class Attack : MonoBehaviour
{

    public GameObject UpCollider;
    public GameObject DownCollider;
    public GameObject RightCollider;
    public GameObject LeftCollider;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {

        }
    }
}
