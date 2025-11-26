using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para cambiar escenas

public class MenuInicio : MonoBehaviour
{
    // Método para iniciar el juego
    public void Jugar()
    {
        // Cambia "EscenaPrincipal" por el nombre de tu escena del juego
        SceneManager.LoadScene("EscenaPrincipal");
    }

    // Método para salir del programa
    public void Salir()
    {
        // Cierra la aplicación
        Application.Quit();

        // Esto solo se verá en el editor (para pruebas)
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
