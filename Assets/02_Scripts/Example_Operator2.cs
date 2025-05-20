using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Operator2 : MonoBehaviour
{
    public int a = 3;
    // Start is called before the first frame update
    void Start()
    {
        print(a);
        print(a++);
        //print(++a);
        print(a);

        print(-a);
        print(-(-a));

        print(1 + 2);   // 리터널(깡숫자)
        print(2 * (2 + 2));
    }

    
}
