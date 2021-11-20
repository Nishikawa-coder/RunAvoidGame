using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePosiotionScript : MonoBehaviour
{
    // Rigidbodyコンポーネントを入れる変数"rb"を宣言する。
public Rigidbody2D rb;

void Start() {
    // Rigidbodyコンポーネントを取得する
    rb = GetComponent<Rigidbody2D>();
}

void FixedUpdate() {
    //right キーで右に進む
    if (Input.GetKey("right")) {
        rb.MovePosition(transform.position + transform.right * 80.0f * Time.deltaTime);
    }
    //left キーで左に進む
    if (Input.GetKey("left")) {
        rb.MovePosition(transform.position - transform.right * 80.0f * Time.deltaTime);
    }
    
}
}
