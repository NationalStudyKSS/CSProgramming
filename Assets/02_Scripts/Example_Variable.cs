using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Variable : MonoBehaviour
{
    public int myNum = 3;   // 정수형 변수 myNum 을 선언해서 3을 때려박는다...
    public float myFloat = 0.5f;  // 실수형 변수 myFloat을 선언해서 0.5f를 때려박는다.
    public string myStr = "안녕하세요!!!";   //문자형 변수 myStr을 선언해서 안녕하세요!!!를 때려박는다...
    
    // 컴퓨터는 못봄... 주석이라고 부름...
    // Start is called before the first frame update
    void Start()
    {
        //print("Hello!!!");
        print(myNum);
        print(myFloat);
        print(myStr);
    }
}