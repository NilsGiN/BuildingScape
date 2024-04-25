using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto colisionado tiene la etiqueta "Enemigo"
        if (other.gameObject.tag == "Enemigo")
        {
            // Busca el objeto del nivel con el script Reiniciar
            Reiniciar reiniciarScript = FindObjectOfType<Reiniciar>();

            // Si se encuentra el script Reiniciar
            if (reiniciarScript != null)
            {
                // Incrementa la variable total del script Reiniciar
                reiniciarScript.total++;
            }

            // Destruye el objeto enemigo
            Destroy(other.gameObject);
        }
    }
}
