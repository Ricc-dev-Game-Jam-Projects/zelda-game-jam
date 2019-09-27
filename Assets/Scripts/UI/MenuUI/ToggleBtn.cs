using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBtn : MonoBehaviour
{
    public GameObject Toggler;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(() =>
        {
            Toggler.SetActive(!Toggler.activeInHierarchy);
        });
    }
}
