using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObstacleEnemy2Script : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);    
    }
}
