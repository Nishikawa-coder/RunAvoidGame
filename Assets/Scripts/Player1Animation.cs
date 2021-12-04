using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Animation : StateMachineBehaviour
{
    [SerializeField] Animator anim;

    private void Update ()
    {
        if( Input.GetKey("right") || Input.GetKey("left"))
        {
            anim.SetBool ( "Player1", true );
        }
        else
        {
            anim.SetBool ( "Player1", false );
        }
    }
    
}
