using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class MonumentUIController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI monumentCounter;
    private int activedMonuments = 0;
    public UnityEvent gameWon = new();
    public static MonumentUIController Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void MomumentActivated()
    {
        activedMonuments++;
        UpdateText();
        if (activedMonuments >= 10)
        {
            Debug.Log("Monumentos amados, llamando pausa");
            gameWon.Invoke();
        }
    }


    private void UpdateText()
    {
        monumentCounter.text = $"{activedMonuments} / 10";
    }
}
