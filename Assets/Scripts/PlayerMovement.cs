using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        // Cogemos el Rigidbody2D del mismo objeto (Player)
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Lee entrada del jugador (teclado)
        float x = Input.GetAxisRaw("Horizontal"); // A/D o Flechas izq/der
        float y = Input.GetAxisRaw("Vertical");   // W/S o Flechas arriba/abajo

        // Normalizamos para que diagonal no vaya más rápido
        movement = new Vector2(x, y).normalized;
    }

    void FixedUpdate()
    {
        // Movimiento con física (FixedUpdate = ritmo constante)
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
