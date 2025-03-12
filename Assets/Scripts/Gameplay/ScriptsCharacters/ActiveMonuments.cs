using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActiveMonuments : MonoBehaviour
{
    [Header("Sprites")]
    [SerializeField] RawImage fog;
    [SerializeField] Sprite deactivateSprite;
    private float fogOpacity = 0.1f;

    private Collider2D activationZone;
    private SpriteRenderer spriteRenderer;
    private bool playerInTrigger = false;


    void Start()
    {
        activationZone = GetComponent<Collider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = true;
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInTrigger = false;
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            SetFogOpacity(fogOpacity);
            activationZone.enabled = false;
            spriteRenderer.sprite = deactivateSprite;
            MonumentUIController.Instance.MomumentActivated();
            AudioManager.Instance.PlayFX("EnvironmentsSound/chorusActivation");
        }
    }

    private void SetFogOpacity(float alpha)
    {

        Color newColor = fog.color;
        newColor.a = Mathf.Clamp01(newColor.a - alpha);
        fog.color = newColor;


    }

}
