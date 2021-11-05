using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlayerScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Rigidbody2D rigid = this.GetComponent<Rigidbody2D>();
        Vector2 now = rigid.position;
        Vector2 force = new Vector2(x * 100.0f, 0.0f);
        // transform.Rotate(new Vector3(0, 0, -1 * 20 * x));
        if (rigid.velocity.magnitude < 40)
        {
            rigid.AddForce(force, ForceMode2D.Force);

        }
        // 丸＋腕
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigid.velocity = Vector2.zero;
        };


    }


}
