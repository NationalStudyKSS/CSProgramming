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
        if (a == 0)    // ���࿡ a�� 0�� ���ٶ��
        {
            print("a�� 0�Դϴ�!!!");
        }

        else if (a > 0)
        {
            print("a�� 0���� Ů�ϴ�...");
        }

        else if (a < 0)
        {
            print("a�� 0���� �۽��ϴ�...");
        }

        else
        {
            print("a�� 0�� �ƴմϴ�...");
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
