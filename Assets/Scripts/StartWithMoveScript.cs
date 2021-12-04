using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartWithMoveScript : MonoBehaviour
{
    public MoveScript next;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(next.Move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
