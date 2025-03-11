using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad del jugador
    private Rigidbody2D rb;
    private Vector2 movement;
    private float xRange = 8.7f;//Limite de movimiento en x
    private float yRange = 4.7f;//Limite de movimiento en y

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Limitar el movimiento en X
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Limitar el movimiento en Y
        if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
        }
        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
        }

        // Captura la entrada del jugador
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        // Normaliza el vector de movimiento para evitar mayor velocidad en diagonales
        movement = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Aplica el movimiento al Rigidbody2D


        if (movement.magnitude > 0)
        {
            rb.linearVelocity = movement * moveSpeed;
        }
        else
        {
            rb.linearVelocity = Vector2.zero; // Detiene el movimiento inmediatamente
        }
    }

}
