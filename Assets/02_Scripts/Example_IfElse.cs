using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_IfElse : MonoBehaviour
{
    public int a = 0;
    public int hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        if (a == 0)    // 만약에 a가 0과 같다라면
        {
            print("a는 0입니다!!!");
        }

        else if (a > 0)
        {
            print("a는 0보다 큽니다...");
        }

        else if (a < 0)
        {
            print("a는 0보다 작습니다...");
        }

        else
        {
            print("a는 0이 아닙니다...");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            print("You Died...");
        }
    }
}
