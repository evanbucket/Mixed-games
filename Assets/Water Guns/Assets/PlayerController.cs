using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool isGrounded;
    private Rigidbody2D rb;
    // OPTIONAL: include if you want to limit x velocity
    private float maxVelX = 10;

    public float xSpeed;
    public float jumpStrength;

    public GameObject water;
    public Transform throwPoint1;

    void Start()
    {
        isGrounded = false;
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("a");
        //water.parentName = "Player2";
        water.SetActive(false);
    }

    void FixedUpdate()
    {
        float xHat = new Vector2(Input.GetAxis("Horizontal"), 0).normalized.x;
        float vx = xHat * xSpeed;
        throwPoint1.position = new Vector3(xHat, throwPoint1.position.y, throwPoint1.position.z);
        rb.AddForce(transform.right * vx);

        float yHat = 0;
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            yHat = 1;
        }
        //yHat = new Vector2(0, ).normalized.y;
        if (isGrounded && yHat == 1) {
            float vy = yHat * jumpStrength;
            isGrounded = false;
            rb.AddForce(transform.up * vy);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            water.SetActive(false);
            water.transform.position = gameObject.transform.position;
            water.SetActive(true);
            water.GetComponent<Rigidbody2D>().AddForce(transform.right * -500f);
        }
        // OPTIONAL: include if you want to limit x velocity
        rb.velocity = new Vector2(Vector2.ClampMagnitude(rb.velocity, maxVelX).x, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = collision.gameObject.tag == "Ground";
    }
}