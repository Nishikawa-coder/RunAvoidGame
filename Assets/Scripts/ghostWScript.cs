using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostWScript : MonoBehaviour
{
    private bool Rendered = false;
    private Rigidbody2D rbody2D;
    public float jumpForce = 1000f;
    public float speed = 5.0f;
    private const string MAIN_CAMERA_TAG_NAME = "MainCamera";
    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            this.rbody2D.AddForce(transform.up * jumpForce);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Rendered)
        {
        this.transform.Translate(-1* speed/50,0.0f,0.0f);
        }
    }
    void OnWillRenderObject()
    {
        if (Camera.current.tag == MAIN_CAMERA_TAG_NAME)
        {
            Rendered = true;
        }
    }
}
