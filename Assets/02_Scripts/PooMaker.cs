using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooMaker : MonoBehaviour
{
    public GameObject pooPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakePoo", 1f, 0.5f);
    }

    void MakePoo()
    {
        Instantiate(pooPrefab, transform.position, transform.rotation);
    }
}
