using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.Playables;
// using UnityEngine.Timeline;

// [RequireComponent(typeof(PlayableDirector))]

public class TextDisplayNoMoveScene : MonoBehaviour
{
    [SerializeField] GameObject spaceObject;
    // [SerializeField] GameObject timeline;
    public float delaytime = 1.0f;
    // public int NextScene = 3;
    public string[] texts;
    int textNumber;
    string displayText;
    int textCharNumber;
    // [SerializeField] private TimelineAsset timeline;
    // private PlayableDirector director;
    
    void Start()
    {
        // director = this.GetComponent<PlayableDirector>();
    }
    public void Update()
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
                // timeline.GetComponent<CallTimeline>().StartTimeline();
                // Invoke(nameof(DelayMethod), delaytime);
            }
        }
        this.GetComponent<Text>().text = displayText;
        
    }
    void DelayMethod()
    {
        // director.Play(timeline);
    }
    
}
