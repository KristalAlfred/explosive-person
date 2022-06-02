using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
           
    }

    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        print(collision.gameObject.name + " just left me :(");
    }

    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        print(otherCollider.name + " OnTriggerEnter2D");
        if(otherCollider is CircleCollider2D otherCircleColl)
        {
            BumpColliderAway(otherCollider, otherCircleColl);
        }
    }

    private void BumpColliderAway(Collider2D otherCollider, CircleCollider2D otherCircleColl)
    {
        Vector3 deltaPos = transform.position - otherCollider.transform.position;
        float othersRadius = otherCircleColl.radius * otherCircleColl.transform.localScale.x;
        float myRadius = circleCollider.radius * transform.localScale.x;
        float wantedDistance = othersRadius + myRadius;
        float ourDistance = deltaPos.magnitude;
        float movement = wantedDistance - ourDistance;
        Vector3 direction = deltaPos.normalized;
        otherCollider.transform.position -= direction * movement;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {

    }
}
