using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeadMaker : MonoBehaviour
{
    public GameObject bead;
    public float x;
    public float z;
    void Start()
    {
        StartCoroutine(GenerateMap());// birden oluþmuyor yavaþ yavaþ gleiyorlar.
    }

    private IEnumerator GenerateMap()//IEnumerator coroutine için
    {
        float staticOffset_x = bead.transform.localScale.x * 0.5f;
        float staticOffset_z = bead.transform.localScale.z * 0.5f;

        float v = x * staticOffset_x;
        for (float i = v - staticOffset_x; i > -v; i -= staticOffset_x * 2)
        {
            float b = z * staticOffset_z;
            for (float j = b - staticOffset_z; j > -b; j -= staticOffset_z * 2)
            {
             GameObject go =  Instantiate(bead, new Vector3(i, 1, j), transform.rotation);
                go.transform.SetParent(transform);
                yield return null;// bekletiyor fonsiyonu
            }
        }
    }
}
