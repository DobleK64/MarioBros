using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterStomp : MonoBehaviour //Monster stomp traducido como pisoton a monstruo
{
    public int valuemoneda = 10;
    public int valuekills = 1;
    private int monedaTotal;
    private int killsTotal;
    public AudioClip enemigoClip;
    private void OnCollisionEnter2D(Collision2D collision) //El jugador tiene un Box collider en los pies que al colisionar con la cabeza del enemigo lo destruye
    {
        if(collision.gameObject.tag == "Weak Point") { 
        killsTotal = GameManager.instance.GetKills();
        killsTotal = valuekills+ killsTotal;                //recuento de kills
        GameManager.instance.SetKills(killsTotal);
            //
        monedaTotal = GameManager.instance.GetPoints();
        monedaTotal = valuemoneda + monedaTotal;
        GameManager.instance.SetPoints(monedaTotal);  //recuento de puntos 
        AudioManager.instance.PlayAudio(enemigoClip, "enemigoSound", false, 1f);
        Destroy(collision.gameObject);
        }
    }
}
