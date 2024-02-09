using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStomp : MonoBehaviour //Monster stomp traducido como pisoton a monstruo
{
    public int value = 10;
    private int monedaTotal;

    private void OnCollisionEnter2D(Collision2D collision) //El jugador tiene un Box collider en los pies que al colisionar con la cabeza del enemigo lo destruye
    {
        if(collision.gameObject.tag == "Weak Point") { 

        monedaTotal = GameManager.instance.GetPoints();
        monedaTotal = value + monedaTotal;
        GameManager.instance.SetPoints(monedaTotal);
        Destroy(collision.gameObject);
        }
    }
}
