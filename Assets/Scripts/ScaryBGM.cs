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
        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }
     //シーンが切り替わった時に呼ばれるメソッド　
    public void PlayMusic()
    {      
        scarybgm.Play();
    }
    public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {      
        //シーンがどう変わったかで判定
        // Scene1からScene2へ
        if (beforeScene == "LastScene4" && nextScene.name == "LastScene5")
        {
            scarybgm.Stop();
            Debug.Log("music stop");
        }
        beforeScene = nextScene.name;
    }

    // public void Destroy()
    // {
    //     Debug.Log("destroy");
    //     Destroy(this.gameObject);
    //     // DestroyImmediate (this, true);        
    // }
}
