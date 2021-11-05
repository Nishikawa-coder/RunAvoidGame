using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    public float speed = 6;
    float vx = 0;
    // bool leftFlag = false;

    //デフォルトで右向きキャラが左向きになるように設定されている。
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            // leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -speed;
            // leftFlag = true;
        }
    }

    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, 0, 0);
        // this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
