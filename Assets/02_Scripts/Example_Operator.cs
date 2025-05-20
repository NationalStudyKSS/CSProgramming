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
        print("덧셈 결과");
        c = a + b;
        print(c);

        print("뺄셈 결과");
        c = a - b;
        print(c);

        print("곱셈 결과");
        c = a * b;
        print(c);

        //print("나눗셈 결과");
        //c = a / b;
        //print(c);
    }

    
}
