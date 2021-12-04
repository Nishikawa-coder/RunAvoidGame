using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplayNoMoveScene : MonoBehaviour
{
    [SerializeField] GameObject spaceObject;
    // [SerializeField] GameObject lastevent;
    //MoveScript nextMoveObj;
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    public MoveScript move;
    public Move2Script move2;    
    public TextDisplayNoMoveScene speak;    
    public EventManagerScript specialEvent;    
    public StopScript stop;    
    public ScaryBGM bgmObject;
    public GameObject activeObject;
    

    void Start()
    {
    }
    public IEnumerator TextDisplay()//次の操作を決める変数
    {
        spaceObject.SetActive(true);
        foreach (string text in texts)
        {
            yield return new  WaitForSeconds(0.1f);
            string displayText = "";
            foreach (char c in text)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                    break;
                yield return new  WaitForSeconds(0.02f);
                displayText += c;
                this.GetComponent<Text>().text = displayText;
            }
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));

        }  
        this.GetComponent<Text>().text = "";
        spaceObject.SetActive(false);
        if(move!=null) StartCoroutine(move.Move());
        if(move2!=null) StartCoroutine(move2.Move());
        if(speak!=null) StartCoroutine(speak.TextDisplay());
        if(stop!=null) StartCoroutine(stop.Stop());
        if(bgmObject!=null) bgmObject.PlayMusic();
        if(activeObject != null) activeObject.SetActive(true);

        if(specialEvent!=null) specialEvent.FadeOut();
        yield break;


        }
    
        
}
