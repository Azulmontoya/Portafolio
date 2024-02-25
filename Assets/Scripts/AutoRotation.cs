using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    public float velocidadRotacion = 30.0f; // Ajusta la velocidad de rotación según tus necesidades

    void Update()
    {
        // Rotar el objeto alrededor del eje Y
        transform.Rotate(Vector3.up, velocidadRotacion * Time.deltaTime);
    }
}
