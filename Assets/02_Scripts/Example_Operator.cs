using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Operator : MonoBehaviour
{
    public int a = 100;
    public int b = 20;
    public int c;

    // Start is called before the first frame update
    void Start()
    {
        print("���� ���");
        c = a + b;
        print(c);

        print("���� ���");
        c = a - b;
        print(c);

        print("���� ���");
        c = a * b;
        print(c);

        //print("������ ���");
        //c = a / b;
        //print(c);
    }

    
}
