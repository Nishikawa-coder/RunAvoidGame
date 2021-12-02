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
    
    public void Start()
    {
    }
     //シーンが切り替わった時に呼ばれるメソッド　
    public void PlayMusic()
    {      
        scarybgm.Play();
    }
    public void StopMusic()
    {
        Debug.Log("stop music");
        scarybgm.Stop();
    }

    // public void Destroy()
    // {
    //     Debug.Log("destroy");
    //     Destroy(this.gameObject);
    //     // DestroyImmediate (this, true);        
    // }
}
