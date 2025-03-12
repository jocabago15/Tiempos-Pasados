using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public Texture2D cursorTexture; // Imagen del cursor

    private static CursorManager instance;

    void Awake()
    {
        // Asegurar que solo haya una instancia del cursor en el juego
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // No destruir al cambiar de escena
        }
        else
        {
            Destroy(gameObject); // Si ya existe, destruir duplicados
        }
    }

    void Start()
    {
        // Asignar el cursor
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);
    }
}
