using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    [SerializeField] float forwardMoveSpeed = 1f;
    [SerializeField] float horizontalMoveSpeed = 1f;
    [SerializeField] Rigidbody rb;
    Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        movement.z = Input.GetAxisRaw("Horizontal") * horizontalMoveSpeed;
        movement.x = -forwardMoveSpeed;
    }

     void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene(2);
        }
    }
}
