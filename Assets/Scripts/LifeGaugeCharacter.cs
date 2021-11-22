using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeGaugeCharacter : MonoBehaviour
{
    //　HP
    [SerializeField]
    public int hp;
    //　LifeGaugeスクリプト
    [SerializeField]
    private LifePanel lifeGauge;
    public string gameOverScene = "GameOverScene1";
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        //　体力の初期化
        hp = 3;
        //　体力ゲージに反映
        lifeGauge.SetLifeGauge(hp);
    }
    void Update(){
        if(this.transform.position.y<-40){
            Time.timeScale = 0;
            SceneManager.LoadScene(gameOverScene);
        }
    }


    //　ダメージ処理メソッド（全削除＆HP分作成）
    public void Damage(int damage)
    {
        hp -= damage;
        //　0より下の数値にならないようにする
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
