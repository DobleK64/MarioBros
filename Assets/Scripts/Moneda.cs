using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.GetComponent<PlayerMovement>()) //Al tocar el jugador la moneda se destruye
        {
            Destroy(gameObject);
        }
    }
}

  