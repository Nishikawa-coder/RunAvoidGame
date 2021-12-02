using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager2Script : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject text2;
    [SerializeField] GameObject text3;
    [SerializeField] GameObject text4;
    [SerializeField] GameObject cat;
    [SerializeField] GameObject player;
    [SerializeField] GameObject maincamera;
    [SerializeField] GameObject spaceObject;
    [SerializeField] GameObject heart;
    public float[] speed;
    public int[] max_counts;
    private int count;


    void Start()
    {
        cat.GetComponent<SpriteRenderer>().flipX = true;
        StartCoroutine("PlayerWalk");
    }
    IEnumerator PlayerWalk()
    {
        yield return new WaitForSeconds(3f);
        count=0;
        while(count<max_counts[0])
        {
            player.transform.Translate(speed[0]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return DisplayText();
    }

    IEnumerator DisplayText()
    {
        spaceObject.SetActive(true);
        StartCoroutine(text.GetComponent<TextDisplayNoMoveScene>().TextDisplay(4));
        yield break;
    }
    public IEnumerator PlayerWalk2()
    {
        spaceObject.SetActive(false);
        count=0;
        while(count<max_counts[0])
        {
            player.transform.Translate(speed[0]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return CameraAndCatMove();
    }
    IEnumerator CameraAndCatMove()
    {
        // Transform CameraTransform = camera.transform;
        Vector3 pos = maincamera.transform.position;
        pos.x=313f;
        maincamera.transform.position=pos;
        Vector3 pos2 = cat.transform.position;
        pos2.x=239f;
        cat.transform.position=pos2;
        yield return PlayerWalk3();
    }
    public IEnumerator PlayerWalk3()
    {
        count=0;
        while(count<max_counts[1])
        {
            player.transform.Translate(speed[1]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return DisplayText2();
    }
    IEnumerator DisplayText2()
    {
        spaceObject.SetActive(true);
        StartCoroutine(text2.GetComponent<TextDisplayNoMoveScene>().TextDisplay(5));
        yield break;
    }
    public IEnumerator CatWalk()
    {
        spaceObject.SetActive(false);
        count=0;
        while(count<max_counts[2])
        {
            cat.transform.Translate(speed[2]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return new WaitForSeconds(0.5f);
        yield return DisplayText3();
    }
    IEnumerator DisplayText3()
    {
        spaceObject.SetActive(true);
        StartCoroutine(text3.GetComponent<TextDisplayNoMoveScene>().TextDisplay(6));
        yield break;
    }
    public IEnumerator PlayerWalk4()
    {
        heart.SetActive(true);
        spaceObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        count=0;
        while(count<max_counts[3])
        {
            player.transform.Translate(speed[3]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }            
        yield return new WaitForSeconds(1f);
        count=0;
        while(count<max_counts[3])
        {
            player.transform.Translate(speed[3]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return new WaitForSeconds(3f);
        text4.SetActive(true);
        yield break;
    }
}
