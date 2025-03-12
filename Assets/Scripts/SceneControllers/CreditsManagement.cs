using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManagement : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
    public void exitCredits()
    {
        PlayerPrefs.Save();
        SceneManager.UnloadSceneAsync("CreditsMenu");
    }
    public void clicSound()
    {
        AudioManager.Instance.PlayFX("start");
    }
}
