using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotate : MonoBehaviour
{
    public Player _player;
    // Update is called once per frame
    void Update()
    {
        if (_player.currentHp == 0) return;
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            //print("<<<<< 왼쪽!!!!!");
            transform.rotation = Quaternion.Euler(0f, 270f, 0f);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //print("!!!!! 오른쪽 >>>>>");
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
    }
}
