using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hikari2Script : MonoBehaviour
{
    [SerializeField] GameObject chasecontroller;
    [SerializeField] GameObject goalText;
    public int NextScene = 3;
    private string hideObjectName = "hikari";
    public float delaytime = 2.0f;
    void Start()
    {
        goalText.SetActive(false);
    }

    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hikari"))
        {
            chasecontroller.GetComponent<AppearScript>().Disappear();
            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
            goalText.SetActive(true);
            Invoke(nameof(DelayMethod), delaytime);
        }
    }
    void DelayMethod()
    {
        // FadeManageScript.FadeOut(NextScene);
        SceneManager.LoadScene(NextScene);
    }

}
