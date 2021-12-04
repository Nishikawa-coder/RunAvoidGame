using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatJump : MonoBehaviour
{
    private Rigidbody2D rbody2D;
    public float delaytime = 0.3f;
    public float jumpForce = 1000f;
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        Invoke("DelayMethod",delaytime);    
    }

    void DelayMethod()
    {
        this.rbody2D.AddForce(transform.up * jumpForce);
        Debug.Log("cat jump!");   
    }
}
