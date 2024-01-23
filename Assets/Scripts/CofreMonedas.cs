using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreMonedas : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>()) //Al tocar el jugador el cofre se destruye
        {
            Destroy(gameObject);
        }
        else
        {
            // evita que el cofre colisionen con otros objetos
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
    }
}
