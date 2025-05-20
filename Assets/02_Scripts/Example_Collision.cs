using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision coll)
    {
        print("부딪힘!!!");
        print(coll.gameObject.name);    //충돌(대상)의 게임오브젝트의 이름
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Trigger!!! 부딪힘!!!");
        print(other.gameObject.name);    //충돌체의 게임오브젝트의 이름
    }
}
