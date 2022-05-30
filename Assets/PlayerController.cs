using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.01f;
    public GameObject bombPrefab;
    public int maxAllowedBombs = 1;
    private int currentlyActiveBombs = 0;
    private float sizeOffset = 0.16f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        UpdateVelocity();
        DropBombs();
    }

    void UpdateVelocity()
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

    void DropBombs()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bombPrefab /* && currentlyActiveBombs < maxAllowedBombs */)
            {
                var tile = GetComponent<TileDetector>();
                Vector3 pos = tile.currentTilePos;
                pos.x += sizeOffset / 2;
                pos.y += sizeOffset / 2;
                Object.Instantiate(bombPrefab, pos, new Quaternion());
                ++currentlyActiveBombs;
            }
        }
    }
}
