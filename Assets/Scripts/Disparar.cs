using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject prefabBala; // Asigna el prefab de la bala desde el editor de Unity
    public float velocidadDisparo = 10f; // Velocidad de disparo
    public float salida = 1f; // Distancia a la que saldr� la bala del personaje

    // M�todo que dispara la bala hacia adelante
    public void DispararBala()
    {
        // Crear una instancia del prefab de la bala
        GameObject bala = Instantiate(prefabBala, transform.position + transform.forward * salida, transform.rotation);

        // Asegurarse de que la bala se destruya autom�ticamente despu�s de un tiempo determinado
        Destroy(bala, 5f);

        // Calcular la direcci�n hacia la que la bala debe viajar (hacia adelante del personaje)
        Vector3 direccion = transform.forward;

        // Agregar velocidad a la direcci�n para que la bala se desplace r�pidamente
        bala.GetComponent<Rigidbody>().velocity = direccion * velocidadDisparo;
    }

    // M�todo Update() que se ejecuta en cada fotograma
    void Update()
    {
        // Disparar la bala cuando se hace clic izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            DispararBala();
        }
    }
}