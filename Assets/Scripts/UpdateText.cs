using System.Collections;
using System.Collections.Generic;
using TMPro; // Vamos a usar cosas del tmp
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    public GameManager.GameManagerVariables variable; //actualiza el texto a la variable de GameManager que le indiquemos
    private TMP_Text textComponent;

    private void Start()
    {
        textComponent = gameObject.GetComponent<TMP_Text>();
    }

    //Update is called once per frame
    void Update() //Contador de tiempo
    {
        switch (variable)
        {
            case GameManager.GameManagerVariables.TIME:
                textComponent.text = "Time: " + GameManager.instance.GetTime().ToString("#.##");
                break;
            case GameManager.GameManagerVariables.POINTS:
                textComponent.text = "Points: " + GameManager.instance.GetPoints();
                break;
            case GameManager.GameManagerVariables.KILLS:
                textComponent.text = "Kills: " + GameManager.instance.GetKills();
                break;
            default:
                break;
        }
    }
}
