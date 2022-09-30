using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedMovible : MonoBehaviour
{


    public float velocidad = 1f;


    void Start()
    {
        transform.position += (Vector3.right * Time.deltaTime);
    }

    void Update()
    {

    }
}
