using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEnemy1Script : MonoBehaviour
{
<<<<<<< HEAD
	[SerializeField] private GameObject obstacleFactory;
    void OnCollisionEnter2D(Collision2D collision)
=======
    void OnCollisionEnter(Collision collision)
>>>>>>> fef193aa6471df8724a9bd3e2fdcbb892c79ccbf
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision.gameObject.tag == "Player")
		{
<<<<<<< HEAD
			obstacleFactory.GetComponent<ObstacleFactoryScript>().SpawnEnemy();
=======
>>>>>>> fef193aa6471df8724a9bd3e2fdcbb892c79ccbf
			// 0.2秒後に消える
			Destroy(gameObject, 0.2f);
		}
	}
}
