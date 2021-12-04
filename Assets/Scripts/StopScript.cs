using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopScript : MonoBehaviour
{
    public float stopTime;
    public MoveScript move;
    public Move2Script move2;    
    public TextDisplayNoMoveScene speak;    
    public EventManagerScript specialEvent;
    public StopScript stop;
    public ScaryBGM bgmObject;
    public GameObject activeObject;                      

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public IEnumerator Stop()
    {
        Debug.Log("stop");
        yield return new WaitForSeconds(stopTime);

        if(move!=null) StartCoroutine(move.Move());
        if(move2!=null) StartCoroutine(move2.Move());
        else if(speak!=null) StartCoroutine(speak.TextDisplay());
        if(specialEvent!=null) specialEvent.FadeOut();
        if(bgmObject!=null) bgmObject.PlayMusic();
        if(stop!=null) StartCoroutine(stop.Stop());
        if(activeObject != null) activeObject.SetActive(true);
        yield break;
    }
}
