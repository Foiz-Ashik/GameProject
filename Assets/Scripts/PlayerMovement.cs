using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed*move,rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isJumping == false) {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            
        }
    }

    private void OncollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")) {
            isJumping = false;
        }
    }

    private void onCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Ground")) {
            isJumping = true;
        }
    }
    public Vector3 GetPosition() {
        return transform.position;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("burger"))
        {
            Destroy(other.gameObject);
        }
    }
}
