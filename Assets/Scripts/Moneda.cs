using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>()) //Al tocar el jugador la moneda se destruye
        {
            Destroy(gameObject);
        }
        else
        {
            // evita que las monedas colisionen con otros objetos
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }
}
  