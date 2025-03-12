using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstructionsShow : MonoBehaviour
{
    public GameObject instructionPanel; // Panel que contiene la imagen y el texto
    public float displayTime = 3f; // Tiempo antes de cambiar de escena
    public string gameSceneName = "TestScene"; // Nombre de la escena del juego

    public void StartGame()
    {
        StartCoroutine(ShowInstructionsAndStart());
    }

    IEnumerator ShowInstructionsAndStart()
    {
        instructionPanel.SetActive(true); // Mostrar panel con imagen y texto
        yield return new WaitForSeconds(displayTime); // Esperar el tiempo definido
        SceneManager.LoadScene(gameSceneName); // Cargar la escena del juego
    }
}
