using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string targetTag = "Boton"; // Asigna el tag que deben tener los objetos clickeables
    public GateMover gate1;
    public GateMover gate2;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Verifica si el objeto clickeado tiene el tag deseado
                if (hit.collider != null && hit.collider.CompareTag(targetTag))
                {
                    gate1.OpenGate();
                    gate2.OpenGate();
                }
            }
        }
    }
}
