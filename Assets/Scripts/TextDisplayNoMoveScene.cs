using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplayNoMoveScene : MonoBehaviour
{
    // [SerializeField] GameObject spaceObject;
    [SerializeField] GameObject lastevent;
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;    
    
    void Start()
    {
        // StartCoroutine("TextDisplay");
    }
    public IEnumerator TextDisplay(int number)
    {
        
        while(textNumber != texts.Length)
        {
            yield return new  WaitForSeconds(0.02f);
            if (textCharNumber != texts[textNumber].Length) 
        {
            //文章を1文字ずつ表示
            displayText = displayText + texts[textNumber][textCharNumber];
            textCharNumber = textCharNumber + 1;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            displayText = "";
            textCharNumber = 0;
            textNumber = textNumber + 1;
        }
            
            this.GetComponent<Text>().text = displayText;
        }
        switch(number){
            case 1:
                StartCoroutine((lastevent).GetComponent<EventManagerScript>().DisplayText2());
                break;
            case 2:
                StartCoroutine((lastevent).GetComponent<EventManagerScript>().CatWalk());
                break;
            case 3:
                StartCoroutine((lastevent).GetComponent<EventManagerScript>().PlayerBackWalk());
                break;
            case 4:
                StartCoroutine((lastevent).GetComponent<EventManager2Script>().PlayerWalk2());
                break;
            case 5:
                StartCoroutine((lastevent).GetComponent<EventManager2Script>().CatWalk());
                break;
            case 6:
                StartCoroutine((lastevent).GetComponent<EventManager2Script>().PlayerWalk4());
                break;
            case 7:
                StartCoroutine((lastevent).GetComponent<EventManager3Script>().CatWalk());
                break;
            case 8:
                FadeManageScript.FadeOut(5);
                break;
            
            

        }
    }
        
}
