using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioDeEscena : MonoBehaviour
{
    // Nombre de la escena que deseas cargar
    public string nombreDeEscena;

    // Llamado cuando ocurra alg�n evento que desee cambiar de escena
    public void CambiarEscena()
    {
        // Cargar la escena por su nombre
        SceneManager.LoadScene(nombreDeEscena);
    }

    // Llamado cuando este objeto colisiona con otro
    private void OnCollisionEnter(Collision collision)
    {
        // Verificar si la colisi�n se produce con un objeto que tiene el tag "Player"
        if (collision.gameObject.CompareTag("Player"))
        {
            // Llamada al m�todo para cambiar de escena
            CambiarEscena();
        }
    }
}
