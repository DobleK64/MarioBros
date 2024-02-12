using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int value = 1;
    private int monedaTotal;
    public AudioClip monedaClip;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.GetComponent<PlayerMovement>()) //Al tocar el jugador la moneda se destruye
        {
            monedaTotal = GameManager.instance.GetPoints();
            monedaTotal = value + monedaTotal;
            GameManager.instance.SetPoints(monedaTotal);
            AudioManager.instance.PlayAudio(monedaClip, "monedaSound", false, 0.1f);
            Destroy(this.gameObject);
        }
    }
}

  