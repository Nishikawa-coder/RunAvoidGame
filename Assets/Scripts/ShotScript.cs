using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotScript : MonoBehaviour
{
    private bool Rendered;
    private const string MAIN_CAMERA_TAG_NAME = "MainCamera";
    public GameObject bullet;
    private int count = 0;
    void Start()
    {
        
        // InvokeRepeating("SpawnBullet", 0f, 3f);
    }

    void SpawnBullet()
    {
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation); 
    }
    
    void Update()
    {
        if(Rendered)
        {
            if(count == 500)
            {
                SpawnBullet();
                count=0;
            }
            else
            {
                count++;
            }
        }
    }
    void OnWillRenderObject()
    {
        if (Camera.current.tag == MAIN_CAMERA_TAG_NAME)
        {
            Rendered = true;
        }
        else
        {
            Rendered = false;
        }
    }
    
}
