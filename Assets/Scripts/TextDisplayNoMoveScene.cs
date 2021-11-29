using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDisplayNoMoveScene : MonoBehaviour
{
    [SerializeField] GameObject spaceObject;
    [SerializeField] GameObject lastevent;
    public float delaytime = 1.0f;
    // public int NextScene = 3;
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    bool eventStarted = false;
    
    
    void Start()
    {
    }
    public void FixedUpdate()
    {
        
        if (textCharNumber != texts[textNumber].Length) 
        {
            //文章を1文字ずつ表示
            displayText = displayText + texts[textNumber][textCharNumber];
            textCharNumber = textCharNumber + 1;
        }
        else
        {
            if (textNumber != texts.Length - 1)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    displayText = "";
                    textCharNumber = 0;
                    textNumber = textNumber + 1;
                }
            }else
            {
                spaceObject.SetActive(false);
                if(eventStarted==false)
                {
                    // lastevent.GetComponent<WalkScript>().StartEvent();
                    eventStarted = true;
                }
                
            }
        }
        this.GetComponent<Text>().text = displayText;
        
    }

    
}
