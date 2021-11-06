using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH_OnCollision_Flip : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(speed, 0);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        speed = -speed;
    }

    // Update is called once per frame

}
