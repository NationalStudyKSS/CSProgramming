using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMesh scoreText;
    public Text _retryScore;

    private void Start()
    {
        scoreText.text = "깨진 돌 : " + score.ToString() + "개";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            score++;
            scoreText.text = "깨진 돌 : " + score.ToString() + "개";
            
            _retryScore.text = "점수 : " + score.ToString();
        }
    }
}
