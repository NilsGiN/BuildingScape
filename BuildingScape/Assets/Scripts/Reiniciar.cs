using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    // Start is called before the first frame update
    public string objetivo = "Monstruos eliminados: ";
    public int total = 0;

    public GameObject cubooculto;
    void Start()
    {
        cubooculto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.R))
       {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }

       if (total == 4)
        {
            cubooculto.SetActive(true);
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 150), "Jugador 1");
        GUI.Label(new Rect(10, 30, 200, 150), objetivo + total);
        GUI.Label(new Rect(10, 50, 200, 150), "Aprieta 'R' Para reiniciar el nivel");
    }
}
