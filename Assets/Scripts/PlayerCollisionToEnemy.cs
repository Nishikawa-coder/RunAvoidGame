using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionToEnemy : MonoBehaviour
{
    [SerializeField] private ChangeLayer changeLayer;
    [SerializeField] private LifeGaugeCharacter lifeGaugeCharacter;

    void Start()
    {
        Time.timeScale = 1;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lifeGaugeCharacter.Damage(1);
            changeLayer.Setlayer();

        }

    }
    
}
