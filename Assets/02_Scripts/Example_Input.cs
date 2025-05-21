using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Input : MonoBehaviour
{
    public GameObject box;

    // Update is called once per frame
    void Update()
    {
        // 만약 키코드의 스페이스가 눌렸다면
        if(Input.GetKeyDown(KeyCode.Space)) // 만약 인풋의 겟키다운이 호출 됐다면
        {
            print("스페이스바 눌림!!!!!!!!!");
            MakeBox();
        }
    }

    void MakeBox()
    {
        Instantiate(box);
    }
}
