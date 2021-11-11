using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
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
            displayText = displayText + texts[textNumber][textCharNumber];//追加
            textCharNumber = textCharNumber + 1;
        }
        else
        {
            if (textNumber != texts.Length - 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    displayText = "";
                    textCharNumber = 0;
                    textNumber = textNumber + 1;
                }
            }
        }
        this.GetComponent<Text>().text = displayText;
        
    }
}
