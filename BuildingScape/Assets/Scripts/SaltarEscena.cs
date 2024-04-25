using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaltarEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public bool ultimaEscenaAlcanzada = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (!ultimaEscenaAlcanzada)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                // Cargar la primera escena o realizar otra acción específica
                SceneManager.LoadScene(0); // Ejemplo de carga de la primera escena
            }
        }
    }
}
