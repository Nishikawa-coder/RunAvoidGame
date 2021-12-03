using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed;
    public int max_count;
    public TextDisplayNoMoveScene next;    

    private int count=0;
    public IEnumerator Move()
    {
        while(count<max_count)
        {
            transform.Translate(speed/50,0,0);
            yield return new WaitForSeconds(0.01f);
            count+=1;
        }
        if(next!=null) StartCoroutine(next.TextDisplay());
        yield break;
    }
    

}
