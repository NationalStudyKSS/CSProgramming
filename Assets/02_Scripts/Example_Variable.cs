using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Variable : MonoBehaviour
{
    public int myNum = 3;   // ������ ���� myNum �� �����ؼ� 3�� �����ڴ´�...
    public float myFloat = 0.5f;  // �Ǽ��� ���� myFloat�� �����ؼ� 0.5f�� �����ڴ´�.
    public string myStr = "�ȳ��ϼ���!!!";   //������ ���� myStr�� �����ؼ� �ȳ��ϼ���!!!�� �����ڴ´�...
    
    // ��ǻ�ʹ� ����... �ּ��̶�� �θ�...
    // Start is called before the first frame update
    void Start()
    {
        //print("Hello!!!");
        print(myNum);
        print(myFloat);
        print(myStr);
    }
}