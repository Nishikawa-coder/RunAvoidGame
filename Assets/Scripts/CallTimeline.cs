using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class CallTimeline : MonoBehaviour
{
    // [SerializeField] private TimelineAsset timeline;

    // private PlayableDirector director;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     this.director = this.GetComponent<PlayableDirector>();
    // }
    
    // public void Play()
    // {
    //     Debug.Log("callplay");
    //     this.director.Play(this.timeline);
    // }
    private PlayableDirector director;
    public GameObject controlPanel;

    private void Awake()
    {
        director = GetComponent<PlayableDirector>();
        director.played += Director_Played;
        director.stopped += Director_Stopped;
    }

    private void Director_Stopped(PlayableDirector obj)
    {
        controlPanel.SetActive(true);
    }

    private void Director_Played(PlayableDirector obj)
    {
        controlPanel.SetActive(false);
    }

    public void StartTimeline()
    {
        Debug.Log("callplay");
        director.Play();
    }
    
}
