using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWithDisplayScript : MonoBehaviour
{
    public TextDisplayNoMoveScene next;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(next.TextDisplay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
