using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    private Transform transf;

    void Start()
    {
        transf = GetComponent<Transform>();
    }
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transf.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transf.Translate(Vector3.right * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transf.Translate(Vector3.down * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transf.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }
}
