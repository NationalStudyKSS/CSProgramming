using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Input : MonoBehaviour
{
    public GameObject box;

    // Update is called once per frame
    void Update()
    {
        // ���� Ű�ڵ��� �����̽��� ���ȴٸ�
        if(Input.GetKeyDown(KeyCode.Space)) // ���� ��ǲ�� ��Ű�ٿ��� ȣ�� �ƴٸ�
        {
            print("�����̽��� ����!!!!!!!!!");
            MakeBox();
        }
    }

    void MakeBox()
    {
        Instantiate(box);
    }
}
