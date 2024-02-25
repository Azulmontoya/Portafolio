using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float sensibilidadRaton = 2.0f;

    private Camera camara;
    private CharacterController characterController;
    private float rotX = 0;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // Desbloquear el cursor al inicio
        Cursor.visible = true; // Hacer el cursor visible
        camara = GetComponentInChildren<Camera>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Movimiento del personaje
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = transform.TransformDirection(new Vector3(movimientoHorizontal, 0, movimientoVertical));
        characterController.SimpleMove(movimiento * velocidadMovimiento);

        // Rotación de la cámara con el ratón
        float rotY = Input.GetAxis("Mouse X") * sensibilidadRaton;
        rotX -= Input.GetAxis("Mouse Y") * sensibilidadRaton;
        rotX = Mathf.Clamp(rotX, -90f, 90f);

        transform.Rotate(0, rotY, 0);
        camara.transform.localRotation = Quaternion.Euler(rotX, 0, 0);
    }
}
