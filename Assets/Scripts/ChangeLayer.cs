using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{
    private float delaytime = 2.0f;
    public SpriteRenderer sp;
    [SerializeField] private GameObject testObject;

    public void Setlayer(int layerNumber){
        testObject.layer = layerNumber;
        //点滅させられないので後々変更する。
        float level = Mathf.Abs(Mathf.Sin(Time.time*10));
        sp.color = new Color(1f,1f,1f,level*0.5f);
        Invoke(nameof(DelayMethod), delaytime);
    }

    void DelayMethod(){
        testObject.layer = 6;
        sp.color = new Color(1f,1f,1f,1f);
    }
}
