using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_Hide : MonoBehaviour
{
    // private string targetObjectName="player";
    // private string hideObjectName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        // bool hided = false;
        // int i = 3;
        // if(collision.gameObject.name==targetObjectName){
        //     while(i>=1){
        //         GameObject hideObject = GameObject.Find("heart"+i.ToString());
        //         if(hideObject!=null){
        //             hideObject.SetActive(false);
        //             hided =true;
        //             Debug.Log(i);
        //             Debug.Log(hided);
        //             return;
        //         }
        //         i--;
        //     }
        //     if(i==1 & hided == true){//ハートが０になったらGAMEOVER
        //         SceneManager.LoadScene("GameOverScene");
        //     }
        // }
        int i = 3;
        if(collision.gameObject.CompareTag("Enemy")){
            GameObject hideObject = GameObject.Find("heart"+i.ToString());
            hideObject.SetActive(false);
            i--;
        }
    }
}
