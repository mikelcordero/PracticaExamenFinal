using UnityEngine;
using UnityEngine.SceneManagement;  // Necesario para cargar escenas

public class DetectarZona : MonoBehaviour
{
    public GameObject uiCanvas;          // El Canvas de UI para mostrar el texto y el botón
    public int escenaDestino = 1;        // Número de la escena a la que se cambiará
    public Color colorZona;              // Color de la zona para aplicar en la otra escena

    private void Start()
    {
        uiCanvas.SetActive(false);       // Inicialmente, la UI está desactivada
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verificamos si la cámara con tag "MainCamera" entra en la zona
        if (other.CompareTag("MainCamera"))
        {
            Debug.Log("Cámara ha entrado en la zona");
            uiCanvas.SetActive(true);     // Activamos la UI cuando la cámara entra en la zona

            // Guardamos el color de la zona seleccionada en PlayerPrefs
            PlayerPrefs.SetString("ColorSeleccionado", ColorUtility.ToHtmlStringRGBA(colorZona));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Si la cámara sale de la zona, desactivamos la UI
        if (other.CompareTag("MainCamera"))
        {
            Debug.Log("Cámara ha salido de la zona");
            uiCanvas.SetActive(false);    // Desactivamos la UI
        }
    }

    // Función llamada cuando el botón de la UI es presionado para ir a la siguiente escena
    public void IrAEscena()
    {
        SceneManager.LoadScene(escenaDestino);   // Cambiar a la escena destino
    }
}
