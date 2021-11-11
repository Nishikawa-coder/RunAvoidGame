using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HikariScript : MonoBehaviour
{
    // public string NextSceneName = "";
    // Start is called before the first frame update
    private string hideObjectName = "hikari";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("hikari"))
        {
            // Time.timeScale = 0;
            Debug.Log("Clear!");
            GameObject hideObject = GameObject.Find(hideObjectName);
            hideObject.SetActive(false);
        }
    }
}
