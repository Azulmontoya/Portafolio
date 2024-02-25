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

            // Desactiva el script llamado "Player" en el objeto con el tag "Player"
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                Player playerScript = playerObject.GetComponent<Player>();
                if (playerScript != null)
                {
                    playerScript.enabled = false;
                }
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            mousePresionado = false;
            // Activa el script llamado "Player" en el objeto con el tag "Player"
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                Player playerScript = playerObject.GetComponent<Player>();
                if (playerScript != null)
                {
                    playerScript.enabled = true;
                }
            }
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
