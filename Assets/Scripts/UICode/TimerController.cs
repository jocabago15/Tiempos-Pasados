using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float elapsedTime = 20f;
    private bool isRunning = true;

    public UnityEvent timeOver = new();

    void Update()
    {
        if (isRunning)
        {
            elapsedTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
    }

    private void UpdateTimerDisplay()
    {
        if (elapsedTime < 1f)
        {
            isRunning = false;
            Debug.Log("Tiempo agotado, invocando evento...");
            timeOver.Invoke();
        }
        int minutes = Mathf.FloorToInt(elapsedTime / 60f);
        int seconds = Mathf.FloorToInt(elapsedTime % 60f);

        timerText.text = string.Format("Tiempo Restante {0:00}:{1:00}", minutes, seconds);
    }
}
