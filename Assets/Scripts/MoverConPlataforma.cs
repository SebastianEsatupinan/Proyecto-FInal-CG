using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverConPlataforma : MonoBehaviour
{
    private Transform plataforma;
    private Vector3 posicionRelativa;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Plataforma")) // Aseg�rate de que la plataforma tenga un tag "Plataforma".
        {
            plataforma = other.transform;
            posicionRelativa = transform.position - plataforma.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Plataforma"))
        {
            plataforma = null;
        }
    }

    private void Update()
    {
        if (plataforma != null)
        {
            // Sigue la posici�n de la plataforma solo en el eje Z.
            Vector3 nuevaPosicion = plataforma.position + posicionRelativa;
            nuevaPosicion.x = transform.position.x; // Mant�n la posici�n en el eje X sin cambios.
            nuevaPosicion.y = transform.position.y; // Mant�n la posici�n en el eje Y sin cambios.
            transform.position = nuevaPosicion;
        }
    }
}
