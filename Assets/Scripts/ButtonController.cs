using UnityEngine;
using TMPro; // Asegúrate de importar el espacio de nombres necesario

public class ButtonController : MonoBehaviour
{
    public GameObject objeto1;
    public GameObject objeto2;
    public TextMeshProUGUI textoTMP; // Asigna tu objeto TextMeshPro desde el Inspector

    void OnMouseDown()
    {
        DesactivarObjetos();
        CambiarTexto();
    }

    void DesactivarObjetos()
    {
        // Desactivar los objetos
        objeto1.SetActive(false);
        objeto2.SetActive(false);
    }

    void CambiarTexto()
    {
        // Cambiar el texto del objeto TextMeshPro
        if (textoTMP != null)
        {
            textoTMP.text = "¡Bien hecho! ahora encuentra la salida";
        }
        else
        {
            Debug.LogWarning("No se ha asignado un objeto TextMeshPro para cambiar el texto.");
        }
    }
}
