using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Example_Translate : MonoBehaviour
{
    public float xPos;
    public float yPos;
    public float zPos;

    public float xLimit;
    public float yLimit;
    public float zLimit;

    // Start is called before the first frame update
    void Start()
    {
        // 이 게임오브젝트에 달려 있는 그 트랜스폼의
        transform.Translate(xPos, yPos, zPos);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xPos, yPos, zPos);
        // 만약에...이 게임오브젝트에 달려있는 그 트랜스폼의 포지션의 x가 9f보다 크다면
        if (transform.position.x > xLimit)
        {
            xPos = -xPos;
        }
        // 만약에...이 게임오브젝트에 달려있는 그 트랜스폼의 포지션의 x가 -9f보다 작다면
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
    }
}
