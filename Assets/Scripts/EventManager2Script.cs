using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager2Script : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject cat;
    [SerializeField] GameObject player;
    [SerializeField] GameObject maincamera;
    [SerializeField] GameObject spaceObject;
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
        yield return new WaitForSeconds(1f);
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
        yield break;
    }
}
