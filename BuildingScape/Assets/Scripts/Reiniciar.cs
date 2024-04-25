using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    // Start is called before the first frame update
    public string jugador = "Jugador # 1";
    public string objetivo = "Monstruos eliminados: ";
    public int total = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.P))
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 150), "jugador: " + jugador);
        GUI.Label(new Rect(10, 30, 200, 150), objetivo + total);
        GUI.Label(new Rect(10, 50, 200, 150), "Aprieta 'P' Para reiniciar el nivel");
    }
}
