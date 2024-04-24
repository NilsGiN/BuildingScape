using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Enemigo")
        {
            Destroy(other.gameObject);
        }
    }
}
