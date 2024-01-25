using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreMonedas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>()) //Al tocar el jugador el cofre se destruye, 
        {
            Destroy(gameObject);
        }
    }
}
       
