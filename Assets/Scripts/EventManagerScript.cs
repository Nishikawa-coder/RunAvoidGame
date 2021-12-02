using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class EventManagerScript : MonoBehaviour
{
    [SerializeField] GameObject cat;
    [SerializeField] GameObject player;
    [SerializeField] GameObject maincamera;
    [SerializeField] GameObject text;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject spaceObject;
    [SerializeField] GameObject showObject;
    [SerializeField] GameObject bgmObject;
    // [SerializeField] GameObject bgm;
    public float[] speed;
    public int[] max_counts;
    private int count;
    void Start()
    {
        FadeManageScript.FadeIn();
        StartCoroutine("DisplayText");
    }
    
    IEnumerator DisplayText()
    {
        yield return new WaitForSeconds(1f);
        showObject.SetActive(true);
        spaceObject.SetActive(true);
        StartCoroutine(text.GetComponent<TextDisplayNoMoveScene>().TextDisplay(1));
        yield break;
    }
    public IEnumerator DisplayText2()
    {
        spaceObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        spaceObject.SetActive(true);
        StartCoroutine(text2.GetComponent<TextDisplayNoMoveScene>().TextDisplay(2));
        yield break;
    }
    public IEnumerator CatWalk()
    {
        spaceObject.SetActive(false);
        Debug.Log("catwalk");
        count=0;
        while(count<max_counts[0])
        {
            cat.transform.Translate(speed[0]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        cat.GetComponent<SpriteRenderer>().flipX = true;
        yield return PlayerWalkwithCamera();
    }
    IEnumerator PlayerWalkwithCamera()
    {
        // Debug.Log("playerwalk");
        count=0;
        while(count<max_counts[1])
        {
            player.transform.Translate(speed[1]/50,0,0);
            maincamera.transform.Translate(speed[1]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return Camera();
    }
    IEnumerator Camera()
    {
        // Debug.Log("camera");
        yield return new WaitForSeconds(1f);
        count=0;
        while(count<max_counts[2])
        {
            maincamera.transform.Translate(speed[2]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return DisplayText3();
    }
    IEnumerator DisplayText3()
    {
        spaceObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        spaceObject.SetActive(true);
        StartCoroutine(text3.GetComponent<TextDisplayNoMoveScene>().TextDisplay(3));
        yield break;
    }
    public IEnumerator PlayerBackWalk()
    {
        bgmObject.GetComponent<ScaryBGM>().PlayMusic();
        // bgm.SetActive(true);
        // DontDestroyOnLoad (bgm.gameObject);
        spaceObject.SetActive(false);
        yield return new WaitForSeconds(1f);
        count=0;
        while(count<max_counts[3])
        {
            player.transform.Translate(speed[3]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return new WaitForSeconds(0.5f);
        count=0;
        while(count<max_counts[3])
        {
            Debug.Log("move");
            player.transform.Translate(speed[3]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return new WaitForSeconds(3f);
        yield return FadeOut();
    }
    IEnumerator FadeOut()
    {
        FadeManageScript.FadeOut(12);
        yield break;
    }
}
