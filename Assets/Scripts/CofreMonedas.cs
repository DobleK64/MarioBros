using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CofreMonedas : MonoBehaviour
{
    public int value = 50;
    private int monedaTotal;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>()) //Al tocar el jugador la moneda se destruye
        {
            monedaTotal = GameManager.instance.GetPoints();
            monedaTotal = value + monedaTotal;
            GameManager.instance.SetPoints(monedaTotal);
            Destroy(this.gameObject);
        }
    }
}
