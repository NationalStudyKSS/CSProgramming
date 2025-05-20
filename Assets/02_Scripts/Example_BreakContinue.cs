using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_BreakContinue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            print(i);
            if (i == 4)
            {
                print("여기가 중간!!!");
                break;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                print("4번은 건너뛰어!!!");
                continue;   // 건너뛰어~!!!
            }
            print(i);
        }
    }

    
}
