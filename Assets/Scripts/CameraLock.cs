using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public string playername;
    private GameObject player;  //プレイヤー情報格納用
    private Vector3 offset; // 相対距離取得用
    public float max_x;
    // Start is called before the first frame update
    void Start()
    {
        //　Playerの情報を取得
        this.player = GameObject.Find(playername);
        offset.x = 40.0f;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (transform.position.x < max_x && player.transform.position.x>=0.0f)
        {
            Vector3 position = transform.position;
        //　新しいトランスフォームの値を代入する
            position.x = player.transform.position.x + offset.x;
            transform.position = position;
        }

    }
}
