using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HikariScript : MonoBehaviour
{
    [SerializeField] GameObject goalText;
    public int NextScene = 3;
    private string hideObjectName = "hikari";
    public float delaytime = 2.0f;
    // public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ
    void Start()
    {
        goalText.SetActive(false);
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hikari"))
        {
            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
            // Time.timeScale = 0;
            // if(isFadeIn)
            // {
            //     StartFadeIn ();
            // }
            goalText.SetActive(true);
            Invoke(nameof(DelayMethod), delaytime);
        }
    }
    void DelayMethod()
    {
        FadeManageScript.FadeOut(NextScene);
    }
    // void StartFadeIn()
    // {
	// 	alfa -= fadeSpeed;                
	// 	SetAlpha ();                      
	// 	if(alfa <= 0){             
	// 		isFadeIn = false;     
	// 		goalText.enabled = false;
	// 	}
	// }
    // void SetAlpha()
    // {
	// 	fadeImage.color = new Color(red, green, blue, alfa);
	// }
}
