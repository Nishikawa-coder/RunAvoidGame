using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatLegScript : MonoBehaviour
{
    private Animator anim;  //Animatorをanimという変数で定義する
    // Start is called before the first frame update
    void Start()
    {
        // anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey("right"))
        // {
        //     anim.SetBool("CatWalkR", true);
        // }
        // else if(Input.GetKey("left"))
        // {
        //     anim.SetBool("CatWalkL", true);
        // }
        // else
        // {
        //     anim.SetBool("CatWalkR", false);
        //     anim.SetBool("CatWalkL", false);
        // }
    }
    public void CatLegFlip(bool flipFlag){
        this.GetComponent<SpriteRenderer>().flipX = flipFlag;
    }
}
