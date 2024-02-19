using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour // Una camara que seguira nuestro jugador en el eje de las x
{

    public GameObject corazon;
    public KeyCode volverAlMenu;


    private void Update()
    {
        if (corazon != null)
        {
            transform.position = new Vector3(corazon.transform.position.x, transform.position.y, transform.position.z);
        }
        //  if (Input.GetKeyDown(volverAlMenu)) { 
        // GameManager.instance.LoadScene("Menu");
        // }
    }
}
