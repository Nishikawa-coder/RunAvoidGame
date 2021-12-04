using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class ScaryBGM : MonoBehaviour
{
    static public ScaryBGM instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }


    public AudioSource scarybgm;
    public string beforeScene;
    
    public void Start()
    {
        beforeScene = "LastScene3";
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }
    public void PlayMusic()
    {      
        scarybgm.Play();
    }
    public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {      

        if (beforeScene == "LastScene4" && nextScene.name == "LastScene5")
        {
            scarybgm.Stop();
            Debug.Log("music stop");
        }
        beforeScene = nextScene.name;
    }

}
