using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicChar : MonoBehaviour
{
    int life;
    float speed = 6;
    float jumpForce = 500;
    float vInput;
    float hInput;

    public GameObject Player;

    void Start()
    {

    }

    void Movement()
    {
        vInput = Input.GetAxis("Vertical");
        hInput = Input.GetAxis("Horizontal");
        Player.transform.Translate(new Vector3(hInput, 0, vInput) * speed * Time.deltaTime);
    }

    void Jump()
    {
        Player.GetComponent<Rigidbody>().AddForce(0, jumpForce, 0);
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

        Movement();

    }
}
