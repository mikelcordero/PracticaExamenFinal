using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para cargar escenas

public class CambiarEscena : MonoBehaviour
{
    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);  // Cambia de escena
    }
}
