using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFactoryScript : MonoBehaviour
{
<<<<<<< HEAD
    public RectTransform enemy;
=======
    public GameObject enemy;

>>>>>>> fef193aa6471df8724a9bd3e2fdcbb892c79ccbf
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ball, transform.position, transform.rotation);
        // Invoke("SpawnEnemy", 0f);    
    }

    public void SpawnEnemy()
    {
<<<<<<< HEAD
        var parent = this.transform;
        // enemy = this.GetComponent<Image>();
        Instantiate(enemy, new Vector3(transform.position.x+400.0f, transform.position.y, transform.position.z), transform.rotation, parent);
=======
        Instantiate(enemy, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
>>>>>>> fef193aa6471df8724a9bd3e2fdcbb892c79ccbf
    }
}
