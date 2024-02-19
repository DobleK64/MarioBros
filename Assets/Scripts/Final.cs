using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    // Start is called before the first frame updat
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>()) 
        {
            AudioManager.instance.ClearAudios();
            GameManager.instance.LoadScene("Final");

        }
    }
}

//El objeto al que se le añada este script cuando es tocado cambiara la escena