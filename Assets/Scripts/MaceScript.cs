using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceScript : MonoBehaviour
{
    public float force_y = 5.0f;
    public float delaytime = 0.8f;
    Rigidbody2D rbody;
    // Start is called before the first frame update
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Invoke(nameof(DelayMethod), delaytime);
        }
    }
    void DelayMethod()
    {
        Rigidbody2D rigid = this.GetComponent<Rigidbody2D>();
        Vector2 now = rigid.position;
        Vector2 force = new Vector2(0.0f, force_y * 1000.0f);
        rigid.AddForce(force, ForceMode2D.Force);
    }

}


