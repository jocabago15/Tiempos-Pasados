using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActiveMonuments : MonoBehaviour
{
    public RawImage bruma;
    private float opacidadPanel = 0.1f;

    private Collider2D triggerZone;
    private bool playerInTrigger = false;

    void Start()
    {
        triggerZone = GetComponent<Collider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = false;
        }
    }

    private void Update()
    {
        if (playerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            SetTextOpacity(opacidadPanel);
            triggerZone.enabled = false;
        }
    }

    private void SetTextOpacity(float alpha)
    {
        Color newColor = bruma.color;
        float currentAlpha = newColor.a;
        newColor.a = currentAlpha - alpha;
        bruma.color = newColor;
    }
}
