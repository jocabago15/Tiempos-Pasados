using UnityEngine;
using UnityEngine.Events;

public class PauseMenu : MonoBehaviour
{
    public GameObject panelMenu;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameManager.Instance != null)
            {
                if (Time.timeScale == 0)
                {
                    panelMenu.SetActive(false);
                    GameManager.Instance.ReloadGame();
                }
                else
                {
                    panelMenu.SetActive(true);
                    GameManager.Instance.PauseGame();
                }
            }
        }
    }
}
