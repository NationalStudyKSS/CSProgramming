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
        print("µ¡¼À °á°ú");
        c = a + b;
        print(c);

        print("»¬¼À °á°ú");
        c = a - b;
        print(c);

        print("°ö¼À °á°ú");
        c = a * b;
        print(c);

        //print("³ª´°¼À °á°ú");
        //c = a / b;
        //print(c);
    }

    
}
