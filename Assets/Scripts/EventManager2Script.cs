using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager2Script : MonoBehaviour
{
    [SerializeField] GameObject text;
    [SerializeField] GameObject cat;
    [SerializeField] GameObject player;
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
        yield return new WaitForSeconds(1f);
        spaceObject.SetActive(true);
        StartCoroutine(text.GetComponent<TextDisplayNoMoveScene>().TextDisplay(3));
        yield break;
    }
    IEnumerator PlayerBackWalk()
    {
        count=0;
        while(count<max_counts[0])
        {
            player.transform.Translate(speed[0]/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return DisplayText();
    }
}
