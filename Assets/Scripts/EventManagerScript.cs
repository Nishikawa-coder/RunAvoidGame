using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class EventManagerScript : MonoBehaviour
{
    public int nextSceneNumber;

    public void FadeOut()
    {
        SceneManager.LoadScene(nextSceneNumber);
    }
    
}
