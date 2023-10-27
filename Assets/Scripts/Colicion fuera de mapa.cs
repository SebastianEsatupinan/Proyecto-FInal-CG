using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Colicionfuerademapa : MonoBehaviour
{
    public GameObject puntoSpawn;

    private void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag == "Player")
        {
            Debug.Log("Saliste del Mapa");
            transform.position = puntoSpawn.transform.position;
        }
    }
}
