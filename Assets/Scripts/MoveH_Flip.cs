using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoveH_Flip : MonoBehaviour
{
    public int maxCount = 50;
    int count = 0;
    bool flipFlag = false;
    public float speed = 5;
    void Start()
    {
        count = 0;
    }
    void FixedUpdate()
    {
        this.transform.Translate(speed / 50, 0, 0);
        count += 1;
        if (count == maxCount)
        {
            this.transform.Rotate(0, 0, 180);
            count = 0;
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;
        }
    }

}
