using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody myRigidBody;

    public float groundSpeed;
    public float flightSpeed;
    public float jumpForce;

    //public Transform groundCheck;
    CapsuleCollider theCollider;

    public bool canFly;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontal, 0f, vertical) * groundSpeed * Time.deltaTime;
        transform.Translate(moveDirection);

        //if (Input.GetKeyDown)
        //isGrounded = Physics.CheckSphere(groundCheck.transform.position, .1f);
        //if (canFly && isGrounded)
        //{
        //    Fly();
        //}
    }

    private void Fly()
    {

    }
}
