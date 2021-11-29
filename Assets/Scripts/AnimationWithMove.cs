using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationWithMove : MonoBehaviour
{
    private Animator anim;
    Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {
        lastPosition = transform.position;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x-lastPosition.x!=0)
        {
            anim.SetBool("walk", true);
            // Debug.Log("Moving");
        }
        else
        {
            anim.SetBool("walk", false);
        }
        lastPosition = transform.position;
    }
}
