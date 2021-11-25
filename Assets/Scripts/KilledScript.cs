using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KilledScript : MonoBehaviour
{
    public GameObject knife;
    public GameObject enemy;
    void Start()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(knife, transform.position, transform.rotation); 
            enemy.SetActive(false);
        }
    }
    
}
