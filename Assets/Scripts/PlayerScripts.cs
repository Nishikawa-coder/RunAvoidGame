using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScripts : MonoBehaviour
{
    
    [SerializeField] GameObject rightmark;
    private Animator anim;  //Animatorをanimという変数で定義する
    public float speed = 6;
    float vx = 0;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        vx = 0;
        if (Input.GetKey("right"))
        {
            vx = speed;
            anim.SetBool("walk", true);
            rightmark.SetActive(false);
            // GetComponent<AudioSource>().PlayOneShot();
        }
        else if (Input.GetKey("left"))
        {
            vx = -speed;
            anim.SetBool("walk", true);
            rightmark.SetActive(false);
            // GetComponent<AudioSource>().PlayOneShot();
        }
        else
        {
            anim.SetBool("walk", false);
        }
    }

    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, 0, 0);
        this.GetComponent<SpriteRenderer>().flipX = (vx < 0);
    }
}
