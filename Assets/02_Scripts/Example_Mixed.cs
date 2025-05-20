using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Mixed : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zPos;

    public float xLimit;
    public float yLimit;
    public float zLimit;

    public float xRot;
    public float yRot;
    public float zRot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xPos, yPos, zPos, Space.World);

        if (transform.position.x > xLimit)
        {
            xPos = -xPos;
        }
        if (transform.position.x < -xLimit)
        {
            xPos = -xPos;
        }
        if (transform.position.y > yLimit)
        {
            yPos = -yPos;
        }
        if (transform.position.y < -yLimit)
        {
            yPos = -yPos;
        }
        if (transform.position.z > zLimit)
        {
            zPos = -zPos;
        }
        if (transform.position.z < -zLimit)
        {
            zPos = -zPos;
        }


        transform.Rotate(xRot, yRot, zRot);
    }
}
