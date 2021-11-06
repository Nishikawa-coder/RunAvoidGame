using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveV_Flip : MonoBehaviour
{
    public int maxCount = 50;
    int count = 0;
    bool flipFlag = false;
    // Start is called before the first frame update
    public float speed = 5;
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //一定時間ごとにずっと行う
    void FixedUpdate()
    {
        this.transform.Translate(0, speed / 50, 0);
        count += 1;
        if (count == maxCount)
        {
            this.transform.Rotate(0, 0, 180);
            count = 0;
            //180度回転するので絵が上下反転させて
            flipFlag = !flipFlag;
            this.GetComponent<SpriteRenderer>().flipY = flipFlag;

        }
    }
}
