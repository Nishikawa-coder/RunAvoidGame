using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationCanvasScript : MonoBehaviour
{
    public float delaytime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        FadeManageScript.FadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        Invoke(nameof(DelayMethod),delaytime);
    }
    void DelayMethod()
    {
        FadeManageScript.FadeOut(3);
    }
}
