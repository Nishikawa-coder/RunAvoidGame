using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour
{
    public float stopTime;
    public MoveScript move;    
    public TextDisplayNoMoveScene speak;    
    public EventManagerScript specialEvent;
    public StopScript stop;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public IEnumerator Stop()
    {
        yield return new WaitForSeconds(stopTime);

        if(move!=null) StartCoroutine(move.Move());
        else if(speak!=null) StartCoroutine(speak.TextDisplay());
        if(specialEvent!=null) specialEvent.FadeOut();
        yield break;
    }
}
