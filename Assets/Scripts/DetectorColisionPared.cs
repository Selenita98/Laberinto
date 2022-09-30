using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredRoja = false;

    float tiempoEnRojo = 5f;

    private void Update()
    {
        if (paredRoja == true)
        {
            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialPorDefecto;
                paredRoja = false;
                tiempoEnRojo = 5f;
            }
        }
    }

   void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
            paredRoja = true;
        }
    }
}
