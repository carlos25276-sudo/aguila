using UnityEngine;
using TMPro; // Necesario para usar TextMeshPro

public class recolectar : MonoBehaviour
{
    public int puntos = 0; // Variable para llevar el puntaje
    public TextMeshProUGUI textoPuntos; // Referencia al texto en la pantalla

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Comprobamos si choca con una gema
        if (collision.CompareTag("Gema"))
        {
            puntos += 5; // <--- Ahora las gemas suman 5 puntos
            Debug.Log("¡Gema recolectada! Puntos: " + puntos);
            ActualizarTexto();
            Destroy(collision.gameObject);
        }
        // Comprobamos si choca con una cereza
        else if (collision.CompareTag("Cereza"))
        {
            puntos += 10; // <--- Ahora las cerezas suman 10 puntos
            Debug.Log("¡Cereza recolectada! Puntos: " + puntos);
            ActualizarTexto();
            Destroy(collision.gameObject);
        }
    }

    void ActualizarTexto()
    {
        if (textoPuntos != null)
        {
            textoPuntos.text = "Puntos: " + puntos;
        }
    }
}