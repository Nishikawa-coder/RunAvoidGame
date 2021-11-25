using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainSoundScript : MonoBehaviour
{
   //シングルトン設定ここから
    static public MainSoundScript instance;

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




    public AudioSource MainBGM;//AudioSource型の変数A_BGMを宣言　対応するAudioSourceコンポーネントをアタッチ
    private string beforeScene;//string型の変数beforeSceneを宣言 

    void Start()
    {
        beforeScene = "StartScene";//起動時のシーン名 を代入しておく
        MainBGM.Play();//A_BGMのAudioSourceコンポーネントに割り当てたAudioClipを再生

        //シーンが切り替わった時に呼ばれるメソッドを登録
        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }
     //シーンが切り替わった時に呼ばれるメソッド　
    void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    {      
        //シーンがどう変わったかで判定
        // Scene1からScene2へ
        if (beforeScene == "InitiateScene" && nextScene.name == "ExplanationScene")
        {
            MainBGM.Stop();
            Debug.Log("music stop");
        }         


        //遷移後のシーン名を「１つ前のシーン名」として保持
        beforeScene = nextScene.name;
    }
}
