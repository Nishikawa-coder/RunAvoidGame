using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeGaugeCharacter : MonoBehaviour
{
    [SerializeField]
    public int hp;
    [SerializeField] private LifePanel lifeGauge;
    public string gameOverScene = "GameOverScene1";
    void Start()
    {
        Time.timeScale = 1;
        lifeGauge.SetLifeGauge(hp);
    }
    void Update(){
        if(this.transform.position.y<-40){
            Time.timeScale = 0;
            SceneManager.LoadScene(gameOverScene);
        }
    }

    public void Damage(int damage)
    {
        hp -= damage;
        hp = Mathf.Max(0, hp);
        if (hp > 0)
        {
            lifeGauge.SetLifeGauge(hp);
        }
        else
        {
            Time.timeScale = 0;
            SceneManager.LoadScene(gameOverScene);
        }
    }
}
