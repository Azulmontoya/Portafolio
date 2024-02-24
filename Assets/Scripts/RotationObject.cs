using UnityEngine;

public class RotationObject : MonoBehaviour
{public float velocidadRotacion = 5.0f;

    private bool mousePresionado = false;
    private Vector3 puntoInicial;
    private float velocidadRotacionActual = 0.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePresionado = true;
            puntoInicial = Input.mousePosition;
            velocidadRotacionActual = 0.0f;
        }

        if (Input.GetMouseButtonUp(0))
        {
            mousePresionado = false;
        }

        if (mousePresionado)
        {
            Vector3 diferencia = Input.mousePosition - puntoInicial;

            // Calcula la velocidad de rotación basada en la diferencia
            velocidadRotacionActual = diferencia.x * velocidadRotacion;

            // Aplica la rotación al objeto
            transform.Rotate(Vector3.up, velocidadRotacionActual * Time.deltaTime);

            // Actualiza el punto inicial para el próximo frame
            puntoInicial = Input.mousePosition;
        }
    }
}
