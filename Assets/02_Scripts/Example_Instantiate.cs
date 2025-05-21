using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Instantiate : MonoBehaviour
{
    public int myNum;       // 정수
    public float myNumF;    // 실수
    public string myStr;    // 문자열

    public GameObject myObj;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
