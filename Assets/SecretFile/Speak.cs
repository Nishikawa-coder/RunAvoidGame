using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speak : MonoBehaviour
{
    public Move next;

    public string text;

    // Start is called before the first frame update
    public void speak()
    {
        Debug.Log(text);

        if(next!=null) next.move();
    }
}
