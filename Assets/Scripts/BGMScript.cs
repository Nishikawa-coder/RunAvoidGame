using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BGMScript : MonoBehaviour
{
   //シングルトン設定ここから（オブジェクトを取得しなくても他のオブジェクトから呼び出せる）
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
    //シングルトン設定ここまで




    public AudioSource mainBGM;
    public AudioSource mainBGM1;
    public string beforeScene;//string型の変数beforeSceneを宣言 
    // public string beforescene = "InitiateScene";
    // public string nextscene = "ExplanationScene";

    public void Start()
    {
        beforeScene = "StartScene";//起動時のシーン名 を代入しておく
        mainBGM.Play();

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }
     //シーンが切り替わった時に呼ばれるメソッド　
    public void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {      
        //シーンがどう変わったかで判定
        // Scene1からScene2へ
        if (beforeScene == "InitiateScene" && nextScene.name == "ExplanationScene")
        {
            mainBGM.Stop();
            Debug.Log("music stop");
        }
        if (beforeScene == "ExplanationScene" && nextScene.name == "MainScene")
        {
            mainBGM1.Play();
        }
        if (beforeScene == "3-4EventScene" && nextScene.name == "LastScene")
        {
            mainBGM1.Stop();
        }
        

        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }
}
