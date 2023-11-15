using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject objetoPrefab;  // Prefab del objeto que se generar�
    public float fuerzaDisparo = 10f; // Fuerza con la que el objeto ser� disparado
    private Animator animador;

    private void Start()
    {
        animador = GetComponent<Animator>();
    }

    private void Update()
    {
        // Detectar clic del mouse
        if (Input.GetMouseButtonDown(0))
        {
            // Reproducir la animaci�n predeterminada
            animador.SetTrigger("AnimacionPredeterminada");

            // Generar y disparar el objeto
            GenerarYDispararObjeto();
        }
    }

    private void GenerarYDispararObjeto()
    {
        // Crear una instancia del objeto prefab
        GameObject nuevoObjeto = Instantiate(objetoPrefab, transform.position, Quaternion.identity);

        // Obtener la direcci�n en la que el personaje est� mirando
        Vector3 direccionDisparo = transform.forward;

        // Aplicar fuerza al objeto para dispararlo en la direcci�n correcta
        Rigidbody rigidbodyObjeto = nuevoObjeto.GetComponent<Rigidbody>();
        if (rigidbodyObjeto != null)
        {
            rigidbodyObjeto.AddForce(direccionDisparo * fuerzaDisparo, ForceMode.Impulse);
        }
    }
}
