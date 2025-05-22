using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveX;
    public float limitX;
    public int maxHp=3;
    public int currentHp;
    public GameObject[] hpImages;
    public GameObject _retryPanel;

    private void Start()
    {
        currentHp = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //print("<<<<< 왼쪽 화살표 눌림!!!!!");
            transform.Translate(-moveX, 0, 0);
            if(transform.position.x < -limitX)
            {
                //print("왼쪽 넘어감!!!");
                transform.position=new Vector3(-limitX, 0, 0);
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //print(">>>>> 오른쪽 화살표 눌림!!!!!");
            transform.Translate(moveX, 0, 0);
            if (transform.position.x > limitX)
            {
                //print("오른쪽 넘어감!!!");
                transform.position = new Vector3(limitX, 0, 0);
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //print("게임 종료!!!");
            Application.Quit();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            currentHp -= 1;
            hpImages[currentHp].SetActive(false);

            print($"현재HP : {currentHp}");
            //Destroy(gameObject);
            
            if (currentHp <= 0)
            {
                Time.timeScale = 0f;
                GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (var enemy in enemies)
                {
                    Destroy(enemy);
                }
                GameObject[] effects = GameObject.FindGameObjectsWithTag("Effect");
                foreach (var effect in effects)
                {
                    Destroy(effect);
                }
                moveX = 0;
                
                _retryPanel.SetActive(true);
            }
            //Application.LoadLevel("24_PooGame");
        }
    }

    public void Retry()
    {
        _retryPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("24_PooGame");
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
