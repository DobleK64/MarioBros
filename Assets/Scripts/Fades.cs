using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fades : MonoBehaviour
{
    private SpriteRenderer _rend;
    // Start is called before the first frame update
    void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        StartCoroutine(FadeOut());
    }

    IEnumerator FadeOut() //Le ha llamado FadeOut porque va disminuyendo el alpha
    {
        Color color = _rend.color; //esto nos sirve para guardar el color actual del objeto
        for (float alpha = 1.0f; alpha >= 0; alpha -= 0.01f) //para ir reduciendo el alpha
        {
            color.a = alpha;
            _rend.color = color;
            yield return new WaitForSeconds(0.02f);
        }
    }
}
