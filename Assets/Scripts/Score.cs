using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Esto es para cargar las funciones del apartado UI de Unity






//                                                                             EXTRA
public class Score : MonoBehaviour //He intentado de todas las maneras posibles que la moneda se sumen de 1 en 1, pero se buguean y a veces suman mas de lo establecido
{
    private int score;
    public Text scoreText;
   
    void Start()
    {
        score = 0;
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.GetComponent<Moneda>()) // Cuando nuestro personaje coge una moneda esta se suma al score y actualiza el texto de la interfaz
        {
            score++;
            scoreText.text = "COINS " + score;
        }
        if(collision.gameObject.GetComponent<CofreMonedas>())
        {
            score += 50;
            scoreText.text = "COINS " + score;
        }
        
    }
}
