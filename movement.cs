using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public float speed=10f;
    public CharacterController controller;
    public float gravity = -9.8f;
    Vector3 velocity;
    public Transform groundcheck;
    public float groundist = 0.4f;
    public LayerMask ground;
    bool isGrounded;
    public float jumpheight = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundcheck.position, groundist, ground);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpheight * gravity * -2f);
        }
        float movex = Input.GetAxis("Horizontal");
        float movez = Input.GetAxis("Vertical");
        Vector3 move = transform.right * movex + transform.forward * movez;
        //Vector3 move = new Vector3(movex, 0f, movez);
        controller.Move(move*speed);
        velocity.y += gravity * Time.deltaTime;
       
        controller.Move(velocity * Time.deltaTime);//free fall
       
    }
}
