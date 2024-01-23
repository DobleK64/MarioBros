using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float speed;
    private SpriteRenderer _rend;
    public Transform corazon;

    void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        corazon = FindAnyObjectByType<PlayerMovement>().transform;

    }

    void Update() 
    {
        // Verificar si el personaje colisiona con el enemigo
        if (corazon !=null) 
        {
            if (transform.position.x < corazon.position.x) //El enemigo sigue a nuestro personaje si se posiciona a la derecha
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                _rend.flipX = false;
            }
            else if (transform.position.x > corazon.position.x)  //El enemigo sigue a nuestro personaje si se posiciona a la izquierda
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                _rend.flipX = true;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) //Cuando el enemigo toca al jugador lo mata
    {
        if(collision.GetComponent<PlayerMovement>())
        {
            Destroy(gameObject);
        }
    

        //sin acabar
        PlayerMovement corazon = collision.gameObject.GetComponent<PlayerMovement>();
        if (corazon)
        {
            corazon.resetCorazon();
        } 
    }
}
