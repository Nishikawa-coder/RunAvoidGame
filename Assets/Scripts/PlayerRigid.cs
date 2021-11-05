using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRigid : MonoBehaviour
{
    Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.gravityScale = 8;
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
