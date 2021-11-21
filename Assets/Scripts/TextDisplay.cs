using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextDisplay : MonoBehaviour
{
    public float delaytime = 2.0f;
    public int NextScene = 3;
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    
    void Start()
    {
    }
    void Update()
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
                Invoke(nameof(DelayMethod), delaytime);
            }
        }
        this.GetComponent<Text>().text = displayText;
        
    }
    void DelayMethod()
    {
        FadeManageScript.FadeOut(NextScene);
    }
}
