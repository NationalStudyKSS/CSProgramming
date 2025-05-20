using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_String : MonoBehaviour
{
    public string myStr = "내 스트링...";
    public string a;
    public string b;

    public int hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        print(myStr);
        print(myStr + a + b);
        print(myStr + hp + a + b);
    }
}
