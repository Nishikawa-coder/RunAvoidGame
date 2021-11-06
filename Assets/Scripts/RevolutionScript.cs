using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolutionScript : MonoBehaviour
{
    public float x = 10.0f;
    public float y = 5.0f;
    // 中心点

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = new Vector3(x, y, 0.0f);
        // 回転軸
        Vector3 axis = new Vector3(0, 0, 1);
        transform.RotateAround(point, axis, 180 * Time.deltaTime);
    }
}
