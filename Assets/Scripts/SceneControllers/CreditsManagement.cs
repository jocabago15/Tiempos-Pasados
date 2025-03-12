using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsManagement : MonoBehaviour
{

    public float speed = 5f; // Variable pública, puedes modificarla en el Inspector
    public void exitCredits()
    {
        PlayerPrefs.Save();
        SceneManager.UnloadSceneAsync("CreditsMenu");
    }
    public void clicSound()
    {
        AudioManager.Instance.PlayFX("start");
    }
void Update()
{
    transform.Translate(Vector3.up * speed * Time.deltaTime);
}
}
