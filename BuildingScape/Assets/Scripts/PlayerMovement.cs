using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Velocidad de movimiento
    public float rotationSpeed = 100.0F; //Velocidad de rotación
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener la entrada del teclado
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calcular la dirección del movimiento
        Vector3 movement = new Vector3(0, 0f, moveVertical).normalized;

        // Mover al jugador
        rb.MovePosition(rb.position + transform.TransformDirection(movement) * speed * Time.deltaTime);
        transform.Rotate(0, moveHorizontal * rotationSpeed * Time.deltaTime, 0);

    }
}
