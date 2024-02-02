using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private List<GameObject> audioList;
    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        audioList = new List<GameObject>();
    }

    // Update is called once per frame
    public AudioSource PlayAudio(AudioClip audioClip, string gameObjectName, bool isLoop = false, float volume = 1.0f) //isLoop y floatvolume son parametros por defecto,
                                                                                                                       //tienen que ir al final siempre y no pueden estar intercalados

    {
        GameObject audioObject = new GameObject(gameObjectName);
        audioObject.transform.SetParent(transform); //todos los audios que se van creando son hijos del AudioManager
        AudioSource audioSourceComponent = audioObject.AddComponent<AudioSource>(); //añado a GameObject nuevo componente AudioSource
        audioSourceComponent.clip = audioClip; //le asignamos el clip al componente y el clip que le asignamos es nuestro metodo
        audioSourceComponent.volume = volume; //la variable del volumen
        audioSourceComponent.loop = isLoop;
        audioSourceComponent.Play();
        audioList.Add(audioObject); //llevar un seguimiento de los objetos que estan sonando en la escena.
        
        
        
        return audioSourceComponent;
    }
    public void ClearAudios()
    {
        foreach(GameObject audioObject in audioList)
        {
            Destroy(audioObject);
        }
        audioList.Clear();  
    }
}
