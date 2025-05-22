using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_Destroy : MonoBehaviour
{
    public float deadTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,deadTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //print("부딪힘!!!");
        if (collision.gameObject.name == "Ground")  //충돌한 게임오브젝트의 이름이 Ground와 같다면
        {
            Destroy(gameObject); 
        }
    }
}
