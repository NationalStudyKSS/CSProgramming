using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Calculator : MonoBehaviour
{
    public int num1 = 0;
    public int num2 = 0;
    public float result = 0;

    // Start is called before the first frame update
    void Start()
    {
        // ===== µ¡¼À =====
        result = num1 + num2;
        print(num1 + " + " + num2 + " = " + result);

        // ===== »¬¼À =====
        result = num1 - num2;
        print(num1 + " - " + num2 + " = " + result);

        // ===== °ö¼À =====
        result = num1 * num2;
        print(num1 + " * " + num2 + " = " + result);

        // ===== ³ª´°¼À =====
        result = (float)num1 / num2;
        print(num1 + " / " + num2 + " = " + result);

        // ===== ³ª¸ÓÁö =====
        result = num1 % num2;
        print(num1 + " % " + num2 + " = " + result);
    }
}
