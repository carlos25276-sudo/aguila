using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // El águila que va a seguir
    public float suavizado = 0.125f; // Velocidad con la que se mueve la cámara
    public Vector3 offset; // Distancia entre la cámara y el águila (Z debe ser -10)

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 posicionDeseada = target.position + offset;
            Vector3 posicionSuavizada = Vector3.Lerp(transform.position, posicionDeseada, suavizado);
            transform.position = posicionSuavizada;
        }
    }
}