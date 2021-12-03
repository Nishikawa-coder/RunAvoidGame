using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2Script : MonoBehaviour
{
    public float speed;
    public int max_count;
    public TextDisplayNoMoveScene speak;
    public MoveScript move;
    public Move2Script move2;
    public EventManagerScript specialEvent;
    public StopScript stop;         

    private int count=0;
    public IEnumerator Move()
    {
        while(count<max_count)
        {
            transform.Translate(speed/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return new WaitForSeconds(1f);
        count = 0;
        while(count<max_count)
        {
            transform.Translate(speed/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        yield return new WaitForSeconds(3f);
        if(move!=null) StartCoroutine(move.Move());
        if(move2!=null) StartCoroutine(move2.Move());
        if(speak!=null) StartCoroutine(speak.TextDisplay());
        if(stop!=null) StartCoroutine(stop.Stop());

        if(specialEvent!=null) specialEvent.FadeOut();
        yield break;
    }
}
