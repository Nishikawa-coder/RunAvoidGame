using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatJump : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    public float delaytime = 0.3f;


    public float jumpForce = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        // FadeManageScript.FadeIn();
        rbody2D = GetComponent<Rigidbody2D>();
        Invoke("DelayMethod",delaytime);    
    }

    // Update is called once per frame
    void DelayMethod()
    {
        this.rbody2D.AddForce(transform.up * jumpForce);
        Debug.Log("cat jump!");   
    }
}
