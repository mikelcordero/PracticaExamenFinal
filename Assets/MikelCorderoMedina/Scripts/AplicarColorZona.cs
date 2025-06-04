using UnityEngine;

public class AplicarColorZona : MonoBehaviour
{
    public GameObject zona;  // Este objeto es el que representará la zona en la EscenaDetecciónPlanos

    void Start()
    {
        // Obtener la zona seleccionada y el color en formato hexadecimal desde PlayerPrefs
        string zonaSeleccionada = PlayerPrefs.GetString("ZonaSeleccionada", "Zona 1");  // Por defecto "Zona 1"
        string colorSeleccionado = PlayerPrefs.GetString("ColorSeleccionado", "#FFFFFF");  // Por defecto blanco

        // Convertir el color desde el formato string hexadecimal
        Color color;
        if (ColorUtility.TryParseHtmlString(colorSeleccionado, out color))
        {
            // Asignar el color a la zona en la EscenaDetecciónPlanos
            zona.GetComponent<Renderer>().material.color = color;
        }
    }
}
