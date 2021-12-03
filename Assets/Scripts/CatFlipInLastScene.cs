using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatFlipInLastScene : MonoBehaviour
{
    private bool fliped = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<200 && fliped==false)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            fliped = true;
        }
        
    }
}
