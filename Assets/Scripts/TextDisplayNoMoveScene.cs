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
    public MoveScript next;    
    public EventManagerScript specialEvent;    

    void Start()
    {
    }
    public IEnumerator TextDisplay()//次の操作を決める変数
    {
        spaceObject.SetActive(true);
        foreach (string text in texts)
        {
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
        if(next!=null) StartCoroutine(next.Move());
        if(specialEvent!=null) specialEvent.FadeOut();
        yield break;


        }
    
        
}
