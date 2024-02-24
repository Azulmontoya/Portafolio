using UnityEngine;

public class Dragon : MonoBehaviour
{
    private Animation anim;

    void Start()
    {
        // Asegúrate de tener el componente Animation adjunto al objeto
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        // Activa la animación1 al presionar la tecla "F"
        if (Input.GetKeyDown(KeyCode.P))
        {
            ActivarAnimacion("Take 001");
        }

        // Activa la animación2 al presionar la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivarAnimacion("Take 002");
        }

        // // Puedes agregar más teclas y animaciones según sea necesario
        // if (Input.GetKeyDown(KeyCode.Alpha1)) // Tecla "1"
        // {
        //     ActivarAnimacion("OtraAnimacion1");
        // }

        // if (Input.GetKeyDown(KeyCode.Alpha2)) // Tecla "2"
        // {
        //     ActivarAnimacion("OtraAnimacion2");
        // }
    }

    void ActivarAnimacion(string nombreAnimacion)
    {
        // Detiene todas las animaciones en curso antes de activar una nueva
        anim.Stop();

        // Activa la animación específica
        anim.Play(nombreAnimacion);
    }
}
