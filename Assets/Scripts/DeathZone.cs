using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()                                                     
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision) // AL PASAR LA LINEA LAS LETRAS SE DESTRUYEN
    {
        
        // devolver pelota pos inicial
        PlayerMovement corazon = collision.gameObject.GetComponent<PlayerMovement>();
        if (corazon)
        {
            corazon.resetCorazon();
        } 
    }
}
