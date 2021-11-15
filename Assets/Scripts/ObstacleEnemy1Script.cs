using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleEnemy1Script : MonoBehaviour
{
	[SerializeField] private GameObject obstacleFactory;
    void OnCollisionEnter2D(Collision2D collision)
	{
		// 衝突した相手にPlayerタグが付いているとき
		if (collision.gameObject.tag == "Player")
		{
			obstacleFactory.GetComponent<ObstacleFactoryScript>().SpawnEnemy();
			// 0.2秒後に消える
			Destroy(gameObject, 0.2f);
		}
	}
}
