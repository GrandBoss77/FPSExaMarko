using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Agent
{
    public CharacterController characterController;

    public float speed = 12.0f;
    public float gravity = -9.81f;
    public float jumpHight = 5.0f;

    public Transform Groundcheck = null;
    public float GroundDistance = 0.4f;
    public LayerMask GroundMask;

    Vector3 velocity = Vector3.zero;

    public void Update()
    {
        bool isGrounded = Physics.CheckSphere(Groundcheck.position, GroundDistance, GroundMask);
        if (isGrounded && velocity.y < 0 && Input.GetKeyDown(KeyCode.Space))
        {
            velocity.y = jumpHight;
        }
        Debug.Log(isGrounded);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        characterController.Move(speed * Time.deltaTime * move);

        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime);
    }


    public override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);
    }
    public override void OnCollisionExit(Collision collision)
    {
        base.OnCollisionExit(collision);
    }
    public override void OnCollisionStay(Collision collision)
    {
        base.OnCollisionStay(collision);
    }
    public override void OnTriggerEnter(Collider collision)
    {
        base.OnTriggerEnter(collision);
    }
    public override void OnTriggerExit(Collider collision)
    {
        base.OnTriggerExit(collision);
    }
    public override void OnTriggerStay(Collider collision)
    {
        base.OnTriggerStay(collision);
    }


}