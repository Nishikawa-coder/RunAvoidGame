using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFlipInLastScene : MonoBehaviour
{
    private bool fliped = false;
    public float flipposision = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<flipposision && fliped==false)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            fliped = true;
        }
        
    }
}
