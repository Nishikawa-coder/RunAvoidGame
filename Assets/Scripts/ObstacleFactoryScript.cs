using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleFactoryScript : MonoBehaviour
{
    public RectTransform enemy;

    void Start()
    {
    }

    public void SpawnEnemy()
    {
        Debug.Log("Spawn");
        var parent = this.transform;
        Instantiate(enemy, new Vector3(transform.position.x, transform.position.y-100.0f, transform.position.z), transform.rotation, parent);
    }
}
