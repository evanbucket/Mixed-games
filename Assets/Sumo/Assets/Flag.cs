using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{

    public GameObject Player;
    public GameObject Goal;
    private Transform destination;
    private bool held = false;
    public bool goal = false;
    public Fell fell;
    private Transform rotation;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == Player)
        {
            held = true;
        }

        if(collision.gameObject == Goal)
        {
            held = false;
            goal = true;
        }

    }
    // Start is called before the first frame updat
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (held == true)
        {
            destination = GameObject.FindGameObjectWithTag("PlayerOne").GetComponent<Transform>();
            rotation = GameObject.FindGameObjectWithTag("PlayerOne").GetComponent<Transform>();
            transform.position = new Vector2 (destination.position.x, destination.position.y);
            transform.rotation = Quaternion.Euler(rotation.eulerAngles.x, rotation.eulerAngles.y, rotation.eulerAngles.z);
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
            
        }
        if (goal == true)
        {
            destination = GameObject.FindGameObjectWithTag("goal1").GetComponent<Transform>();
            transform.position = new Vector2 (destination.position.x, destination.position.y);
        }
        if (fell.fell == true)
        {
            held = false;
            transform.position = new Vector2(10, 0);
            transform.rotation = Quaternion.Euler(0, 0, 180);
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;

        }
    }
}
