using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float stop_position_x = 410.0f;
    public float speed = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed, 0.0f, 0.0f);
        if (this.transform.position.x >= stop_position_x)
        {
            speed = 0.0f;
        }
    }
}
