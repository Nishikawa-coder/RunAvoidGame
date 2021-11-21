using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    private Animator anim;  //Animatorをanimという変数で定義する
    // [SerializeField] GameObject catleg;
    // [SerializeField] GameObject body;
    public float speed = 6;
    float vx = 0;
    // bool leftFlag = false;

    //デフォルトで右向きキャラが左向きになるように設定されている。
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            anim.SetBool("walk", true);
        }
        else if (Input.GetKey("left"))
        {
            vx = -speed;
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }

    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, 0, 0);
        // catleg.GetComponent<CatLegScript>().CatLegFlip(vx < 0);
        // body.GetComponent<BodyScript>().BodyFlip(vx < 0);
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }
}
