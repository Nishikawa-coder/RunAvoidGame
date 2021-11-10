using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionToEnemy : MonoBehaviour
{
    [SerializeField] private ChangeLayer changeLayer;
    [SerializeField] private LifeGaugeCharacter lifeGaugeCharacter;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            lifeGaugeCharacter.Damage(1);
            changeLayer.Setlayer(7);

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
