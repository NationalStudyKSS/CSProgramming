using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
    public Image _skill;
    public float skillTimer;
    public float skillTime;
    
    private void Start()
    {
        skillTimer = skillTime;
    }

    private void Update()
    {
        skillTimer -= Time.deltaTime;
        _skill.fillAmount = (skillTime - skillTimer) / skillTime;
        if(skillTimer<=0&&Input.GetKeyDown(KeyCode.Q))
        {
            Skill1();
            skillTimer = skillTime;
        }
    }

    public void Skill1()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (var enemy in enemies)
        {
            Destroy(enemy);
        }
    }
}
