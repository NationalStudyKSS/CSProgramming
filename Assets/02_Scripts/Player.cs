using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveX;
    public float limitX;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //print("<<<<< 왼쪽 화살표 눌림!!!!!");
            transform.Translate(-moveX, 0, 0);
            if(transform.position.x < -limitX)
            {
                //print("왼쪽 넘어감!!!");
                transform.position=new Vector3(-limitX, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //print(">>>>> 오른쪽 화살표 눌림!!!!!");
            transform.Translate(moveX, 0, 0);
            if (transform.position.x > limitX)
            {
                //print("오른쪽 넘어감!!!");
                transform.position = new Vector3(limitX, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("게임 종료!!!");
            Application.Quit();
        }
    }
}
