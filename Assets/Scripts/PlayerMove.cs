// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMove : MonoBehaviour
// {
//     public float initialMoveSpeed = 3;
//     private float moveSpeed; // Declare the variable here
//     public float jumpForce = 5;
//     private bool isGrounded;
//     private bool isJumping = false;
//     private Rigidbody rb;
//     private Animator animator;
//     public GameObject playerObject;
//     public AudioSource Jump;

//     private const string JUMP_ANIMATION = "Jump";
//     private const string RUN_ANIMATION = "Standard Run";

//     private float timeElapsed = 0f;
//     public float speedIncreaseRate = 0.1f; // Adjust this rate as needed

//     void Start()
//     {
//         rb = GetComponent<Rigidbody>();
//         animator = playerObject.GetComponent<Animator>();
//         moveSpeed = initialMoveSpeed; // Initialize the moveSpeed variable
//     }

//     void Update()
//     {
//         // Increase speed over time
//         timeElapsed += Time.deltaTime;
//         moveSpeed = initialMoveSpeed + speedIncreaseRate * timeElapsed;

//         // Player movement
//         transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);

//         // Jumping
//         if (isGrounded && Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
//         {
//             rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
//             isGrounded = false;
//             isJumping = true;
//             animator.Play(JUMP_ANIMATION);
//             Jump.Play();
//         }
//     }

//     // Check if the player is grounded
//     private void OnCollisionEnter(Collision collision)
//     {
//         if (collision.gameObject.CompareTag("Ground"))
//         {
//             isGrounded = true;
//             if (!isJumping)
//             {
//                 animator.Play(RUN_ANIMATION);
//             }
//             isJumping = false;
//         }
//     }

//     private void OnCollisionExit(Collision collision)
//     {
//         if (collision.gameObject.CompareTag("Ground"))
//         {
//             isGrounded = false;
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float initialMoveSpeed = 3;
    private float moveSpeed;
    public float jumpForce = 5;
    private bool isGrounded;
    private bool isJumping = false;
    private Rigidbody rb;
    private Animator animator;
    public GameObject playerObject;
    public AudioSource Jump;

    private const string JUMP_ANIMATION = "Jump";
    private const string RUN_ANIMATION = "Standard Run";

    private float timeElapsed = 0f;
    public float speedIncreaseRate = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = playerObject.GetComponent<Animator>();
        moveSpeed = initialMoveSpeed;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        moveSpeed = initialMoveSpeed + speedIncreaseRate * timeElapsed;

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);

        if (isGrounded && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            isJumping = true;
            animator.Play(JUMP_ANIMATION);
            Jump.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            if (!isJumping)
            {
                animator.Play(RUN_ANIMATION);
            }
            isJumping = false;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
