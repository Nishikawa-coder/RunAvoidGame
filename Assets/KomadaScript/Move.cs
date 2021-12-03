using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Speak next;


    // Start is called before the first frame update
    public void move()
    {
        Debug.Log("動いた");

        if(next!=null) next.speak();
    }
    
}
