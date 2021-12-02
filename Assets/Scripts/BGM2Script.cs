using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BGM2Script : MonoBehaviour
{
    static public BGM2Script instance;

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
    
    // public new void Start()
    // {
    //     beforeScene = "StartScene";//起動時のシーン名 を代入しておく
    //     //シーンが切り替わった時に呼ばれるメソッドを登録
    //     SceneManager.activeSceneChanged += OnActiveSceneChanged;
    // }
    //  //シーンが切り替わった時に呼ばれるメソッド　
    // public new void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
    // {      
    //     //シーンがどう変わったかで判定
    //     // Scene1からScene2へ
    //     if (beforeScene == beforescene && nextScene.name == nextscene)
    //     {
    //         MainBGM.Play();
    //     }
    //     if (beforeScene == "3-4EventScene" && nextScene.name == "LastScene")
    //     {
    //         MainBGM.Stop();
    //     }

    //     //遷移後のシーン名を「１つ前のシーン名」として保持
    //     beforeScene = nextScene.name;
    // }
}
