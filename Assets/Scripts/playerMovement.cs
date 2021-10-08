using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 1;
    [SerializeField]
    float jumpSpeed = 100;
    [SerializeField]
    float gravity;
    [SerializeField]
    Transform cam;

    Rigidbody rb;

    float normJumpSpeed;

    bool canJump = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        normJumpSpeed = jumpSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.down * gravity * rb.mass);

        canJump = false;
        jumpSpeed = normJumpSpeed;

        Ray r = new Ray(transform.position, Vector3.down);

        RaycastHit hit;

        Debug.DrawLine(r.origin, r.origin + Vector3.down * 10);

        if (Physics.Raycast(r, out hit, 3))
        {
            if (hit.transform.tag == "walkable" && hit.transform != null)
            {
                canJump = true;
                if(hit.transform.GetComponent<NOTSCRIPT_bouncy>())
                {
                    jumpSpeed = jumpSpeed * 2;
                }
            }
            Debug.Log(hit.transform.name);
        }

        Debug.Log(canJump);

        //mobility//

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;
        camForward.Normalize();
        camRight.Normalize();

        Vector3 moveDirection = (camForward * v * moveSpeed) + (camRight * h * moveSpeed);



        rb.velocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);

        if (Input.GetButtonDown("Jump") && canJump)
        {

            Jump();
        }
    }

    void Jump()
    {

        rb.velocity = new Vector3(rb.velocity.x, jumpSpeed, rb.velocity.y);
    }
}
