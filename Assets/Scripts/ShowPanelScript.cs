using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanelScript : MonoBehaviour
{
    public float delaytime = 1.0f;
    [SerializeField] GameObject showObject;
    // Start is called before the first frame update
    void Start()
    {
        showObject.SetActive(false);
        Invoke(nameof(DelayMethod),delaytime);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void DelayMethod()
    {
        showObject.SetActive(true);
    }
}
