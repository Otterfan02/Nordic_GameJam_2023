using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float dragConstant;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Time.deltaTime * speed * Vector2.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Time.deltaTime * -speed * Vector2.up);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Time.deltaTime * speed * Vector2.left);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Time.deltaTime * speed * -Vector2.left);

        }


        rb.velocity = rb.velocity * dragConstant;

    }
}
