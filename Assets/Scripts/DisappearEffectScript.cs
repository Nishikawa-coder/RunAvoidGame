using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearEffectScript : MonoBehaviour
{
    public GameObject knife;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke(nameof(DelayMethod),0.7f);
    }
    void DelayMethod()
    {
        knife.SetActive(false);
    }
}
