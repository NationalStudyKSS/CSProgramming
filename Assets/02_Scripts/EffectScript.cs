using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectScript : MonoBehaviour
{
    public GameObject effect;
    public float effectY = 2f;

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 spawnPos = transform.position;
        spawnPos.y = effectY;
        Instantiate(effect, spawnPos, Quaternion.identity);
    }
}
