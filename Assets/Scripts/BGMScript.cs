using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BGMScript : MonoBehaviour
{
    static public BGMScript instance;

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

    public AudioSource mainBGM;
    public AudioSource mainBGM1;
    public string beforeScene;

    public void Start()
    {
        beforeScene = "StartScene";
        mainBGM.Play();

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }
     //シーンが切り替わった時に呼ばれるメソッド　
    public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {      
        if (beforeScene == "InitiateScene" && nextScene.name == "ExplanationScene")
        {
            mainBGM.Stop();
        }
        if (beforeScene == "ExplanationScene" && nextScene.name == "MainScene")
        {
            mainBGM1.Play();
        }
        if (beforeScene == "3-4EventScene" && nextScene.name == "LastScene")
        {
            mainBGM1.Stop();
        }
        
        beforeScene = nextScene.name;
    }
}
