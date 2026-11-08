using UnityEngine;

public class AguilaController : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private Animator anim;
    private int puntaje = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float movimientoX = 0f;
        float movimientoY = 0f;

        if (Input.GetKey(KeyCode.W)) movimientoY = 1f;
        if (Input.GetKey(KeyCode.S)) movimientoY = -1f;
        if (Input.GetKey(KeyCode.A)) movimientoX = -1f;
        if (Input.GetKey(KeyCode.D)) movimientoX = 1f;

        // Aplicar movimiento f�sico
        rb.linearVelocity = new Vector2(movimientoX, movimientoY) * velocidad;

        // Activar o desactivar la animaci�n seg�n el movimiento
        if (anim != null)
        {
            bool estaMoviendo = (movimientoX != 0f || movimientoY != 0f);
            anim.SetBool("Moviendo", estaMoviendo);
        }
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Gema"))
        {
            Destroy(otro.gameObject);
            puntaje += 10;
            Debug.Log("Puntaje: " + puntaje);
        }
        else if (otro.CompareTag("Cereza"))
        {
            Destroy(otro.gameObject);
            puntaje -= 5;
            Debug.Log("Puntaje: " + puntaje);
        }
    }
}