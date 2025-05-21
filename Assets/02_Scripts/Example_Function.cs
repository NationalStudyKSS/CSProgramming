using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Function : MonoBehaviour
{
    void MyFunction()   // 1. 기본형
    {
        print("내가 만든 함수!!!");
    }

    void MyFunctionWithParam(string str)    // 2. 매개변수가 있는 함수
    {
        print("내가 만든 매개변수가 있는 함수!!!");
        print("전달 받은 문자열 ::: " + str);
    }

    int MyFunctionReturn()  // 3. 반환형 함수
    {
        return 1;
    }


    int MyFunctionReturnWithParam(int a, int b) // 4. 매개변수가 있는 반환형
    {
        return a+b;
    }

    // Start is called before the first frame update
    void Start()
    {
        print("안녕하세요...");
        MyFunction();
        MyFunctionWithParam("매개변수 인자");
        print(MyFunctionReturn());
        print(MyFunctionReturnWithParam(3, 4));
    }

    
}
