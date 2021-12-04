using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirectionForPlayer : MonoBehaviour
{
    public float speed = 10f;
    private CharacterController controller;
    private Vector3 moveDirection;
    public float gravity = 8.0F;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //地面についている時
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection = transform.TransformDirection(moveDirection) * speed;
        }
        //重力分変更する
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
