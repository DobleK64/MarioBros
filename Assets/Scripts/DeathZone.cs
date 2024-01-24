using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) // AL CAER AL VACIO EL CORAZON VUELVE A LA POSICION INICIAL
    {       
        PlayerMovement corazon = collision.gameObject.GetComponent<PlayerMovement>();
        if (corazon)
        {
            corazon.resetCorazon();
        } 
    }
}
