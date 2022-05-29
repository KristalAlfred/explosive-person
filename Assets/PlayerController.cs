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
        Vector3 position = this.gameObject.transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            position.Set(position.x, position.y + speed, position.z);
        }

        if (Input.GetKey(KeyCode.S))
        {
            position.Set(position.x, position.y - speed, position.z);
        }

        if (Input.GetKey(KeyCode.A))
        {
            position.Set(position.x - speed, position.y, position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.Set(position.x + speed, position.y, position.z);
        }

        this.gameObject.transform.position = position;
    }
}
