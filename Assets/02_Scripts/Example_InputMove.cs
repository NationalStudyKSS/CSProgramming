using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_InputMove : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("<<<<< 왼쪽 화살표 눌림!!!!!");
            transform.Translate(-1f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print(">>>>> 오른쪽 화살표 눌림!!!!!");
            transform.Translate(1f, 0, 0);
        }
    }
}
