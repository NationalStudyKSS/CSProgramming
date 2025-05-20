using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_While : MonoBehaviour
{
    public int n = 0;
    public int i = 1;
    public int j = 2;
    public int k = 0;

    // Start is called before the first frame update
    void Start()
    {
        while (n < 5) // ~하는 동안
        {
            print(n);
            n++;
        }

        while (j < 10)
        {
            i = 1;
            while (i < 10)
            {
                print(j + " x " + i + " = " + j * i);
                i++;
            }
            j++;
        }

        do
        {
            print("Do!!");
            k++;
        } while (k < 5);
    }
}
