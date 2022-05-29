using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        print("PlayerController script started");
    }

    // Update is called once per frame
    void Update()
    {
        var body = GetComponent<Rigidbody2D>();
        Vector2 velocity = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            velocity.y -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += speed;
        }
        body.velocity = velocity;
    }
}
