using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float velocidad = 5.0f; // Velocidad de movimiento
    public float rangoX = 10.0f;   // Rango de movimiento en el eje X
    public float rangoZ = 10.0f;   // Rango de movimiento en el eje Z

    void Update()
    {
        // Calcula un valor aleatorio para el eje X y Z
        float movimientoX = Random.Range(-rangoX, rangoX);
        float movimientoZ = Random.Range(-rangoZ, rangoZ);

        // Calcula el desplazamiento en la dirección deseada
        Vector3 desplazamiento = new Vector3(movimientoX, 0, movimientoZ);

        // Mueve el objeto en la dirección calculada
        transform.Translate(desplazamiento * velocidad * Time.deltaTime);
    }
}
