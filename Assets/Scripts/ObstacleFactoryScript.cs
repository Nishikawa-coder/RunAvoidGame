using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFactoryScript : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, transform.rotation);
        // Invoke("SpawnEnemy", 0f);    
    }

    public void SpawnEnemy()
    {
        Instantiate(enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }
}
