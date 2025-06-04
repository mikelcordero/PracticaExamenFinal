using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverEscena : MonoBehaviour
{
    public void VolverAEscenaInicial()
    {
        SceneManager.LoadScene("Scene1");  // Cambia a la escena inicial
    }
}
