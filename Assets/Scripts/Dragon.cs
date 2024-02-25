using UnityEngine;

public class Dragon : MonoBehaviour
{
    private Animation anim;
    public GameObject fireflame;
    private bool isAnimation1Active = true;

    void Start()
    {
        // Asegúrate de tener el componente Animation adjunto al objeto
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        // Activa la animación1 o animación2 al presionar la tecla "P"
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isAnimation1Active)
            {
                ActivarAnimacion("Take 001");
                fireflame.SetActive(true);
            }
            else
            {
                ActivarAnimacion("Take 002");
                fireflame.SetActive(false);
            }

            // Cambia el estado del booleano para la próxima vez
            isAnimation1Active = !isAnimation1Active;
        }
    }

    void ActivarAnimacion(string nombreAnimacion)
    {
        // Detiene todas las animaciones en curso antes de activar una nueva
        anim.Stop();

        // Activa la animación específica
        anim.Play(nombreAnimacion);
    }
}
