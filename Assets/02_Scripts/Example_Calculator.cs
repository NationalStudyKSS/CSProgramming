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
        // ===== 덧셈 =====
        result = num1 + num2;
        print(num1 + " + " + num2 + " = " + result);

        // ===== 뺄셈 =====
        result = num1 - num2;
        print(num1 + " - " + num2 + " = " + result);

        // ===== 곱셈 =====
        result = num1 * num2;
        print(num1 + " * " + num2 + " = " + result);

        // ===== 나눗셈 =====
        result = (float)num1 / num2;
        print(num1 + " / " + num2 + " = " + result);

        // ===== 나머지 =====
        result = num1 % num2;
        print(num1 + " % " + num2 + " = " + result);
    }
}
