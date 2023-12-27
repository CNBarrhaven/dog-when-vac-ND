using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float yForce;
    private Rigidbody2D enemyRigidBody;
    public float speed;
    public int ohno;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(0, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
    }
    private void FixedUpdate() {
        if (transform.position.x <= -8)
        {
            speed = speed * -1;
        }
        if (transform.position.x >= 8)
        {
            speed = speed * -1;
        }
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;

        if (ohno == 2)
        {

            // Start is called before the first frame update

            // Update is called once per frame

            //zig zag
            
        }
    }
}


