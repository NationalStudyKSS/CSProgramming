using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_MixedKey5 : MonoBehaviour
{
    public GameObject box;
    // Start is called before the first frame update
    void Start()
    {
        //MakeBox();
        InvokeRepeating("MakeBox", 1f, 1f);
    }

    void MakeBox()
    {
        Instantiate(box);
    }
}
