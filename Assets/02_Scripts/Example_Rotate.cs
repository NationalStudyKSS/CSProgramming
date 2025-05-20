using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Rotate : MonoBehaviour
{
    public float xRot;
    public float yRot;
    public float zRot;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(xRot, yRot, zRot);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRot, yRot, zRot);
    }
}
