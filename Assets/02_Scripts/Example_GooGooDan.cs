using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_GooGooDan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(2 + " x " + 1 + " = " + 2 * 1);
        //print(2 + " x " + 2 + " = " + 2 * 2);
        //print(2 + " x " + 3 + " = " + 2 * 3);
        //print(2 + " x " + 4 + " = " + 2 * 4);
        //print(2 + " x " + 5 + " = " + 2 * 5);
        //print(2 + " x " + 6 + " = " + 2 * 6);
        //print(2 + " x " + 7 + " = " + 2 * 7);
        //print(2 + " x " + 8 + " = " + 2 * 8);
        //print(2 + " x " + 9 + " = " + 2 * 9);
        
        //print(3 + " x " + 1 + " = " + 3 * 1);
        //print(3 + " x " + 2 + " = " + 3 * 2);
        //print(3 + " x " + 3 + " = " + 3 * 3);
        //print(3 + " x " + 4 + " = " + 3 * 4);
        //print(3 + " x " + 5 + " = " + 3 * 5);
        //print(3 + " x " + 6 + " = " + 3 * 6);
        //print(3 + " x " + 7 + " = " + 3 * 7);
        //print(3 + " x " + 8 + " = " + 3 * 8);
        //print(3 + " x " + 9 + " = " + 3 * 9);

        for (int i = 2; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                print(i + " x " + j + " = " + i * j);
            }
        }
    }

}
