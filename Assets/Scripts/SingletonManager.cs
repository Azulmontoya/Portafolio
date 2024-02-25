using UnityEngine;

public class SingletonManager : MonoBehaviour
{
    private static SingletonManager _instancia;
    public int selection;

    // Propiedad para acceder a la instancia desde otras clases
    public static SingletonManager Instancia
    {
        get
        {
            // Si la instancia aún no existe, la crea
            if (_instancia == null)
            {
                GameObject singletonObject = new GameObject("SingletonManager");
                _instancia = singletonObject.AddComponent<SingletonManager>();
            }

            return _instancia;
        }
    }

    // Otros miembros de la clase pueden ir aquí

    private void Awake()
    {
        // Asegura que solo haya una instancia de la clase
        if (_instancia != null && _instancia != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instancia = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Métodos y lógica de la clase pueden ir aquí
}
