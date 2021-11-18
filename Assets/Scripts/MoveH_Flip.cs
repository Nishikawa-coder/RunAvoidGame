using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveH_Flip : MonoBehaviour
{

    public int maxCount = 50;
    int count = 0;
    bool flipFlag = false;
    // Start is called before the first frame update
    public float speed = 5;
    public float delaytime = 1.0f;
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
            //180度回転するので絵が上下反転させて
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;
            // Debug.Log("stop!");
            // this.transform.Translate(0, 0, 0);
            // Invoke(nameof(FlipMove), delaytime);
        }
    }
    // void FlipMove()
    // {
    //     this.transform.Rotate(0, 0, 180);
    //     count = 0;
    //     //180度回転するので絵が上下反転させて
    //     flipFlag = !flipFlag;
    //     this.GetComponent<SpriteRenderer>().flipY = flipFlag;
    // }

}
