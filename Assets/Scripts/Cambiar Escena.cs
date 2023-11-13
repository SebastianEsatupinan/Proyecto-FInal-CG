using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Nombre de la escena que deseas cargar
    public string nombreDeEscena;

    // Llamado cuando ocurra algún evento que desee cambiar de escena
    public void CambiarEscena()
    {
        // Cargar la escena por su nombre
        SceneManager.LoadScene(nombreDeEscena);
    }

    // Llamado cuando este objeto colisiona con otro
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            Debug.Log("Pasaste al nivel 3");
            // Llamada al método para cambiar de escena
            CambiarEscena();
        }
    }
}
