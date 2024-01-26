using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MataJugador : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision) // Cuando el enemigo toca a nuestro personaje lo mata
    {
        if(collision.gameObject.tag == "Player")
        {
            print("Hola");
            Camera.main.transform.parent = null;
            Destroy(collision.gameObject);
        }
    }
}
