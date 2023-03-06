using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag2 : MonoBehaviour
{

    public GameObject Player;
    public GameObject Goal;
    private Transform destination;
    private bool held = false;
    public bool goal = false;
    public Fell2 fell;
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
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (held == true)
        {
            destination = GameObject.FindGameObjectWithTag("PlayerTwo").GetComponent<Transform>();
            rotation = GameObject.FindGameObjectWithTag("PlayerTwo").GetComponent<Transform>();
            transform.position = new Vector2 (destination.position.x, destination.position.y);
            transform.rotation = Quaternion.Euler(rotation.eulerAngles.x, rotation.eulerAngles.y, 180 + rotation.eulerAngles.z);
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
        }
        if (goal == true)
        {
            destination = GameObject.FindGameObjectWithTag("goal2").GetComponent<Transform>();
            transform.position = new Vector2 (destination.position.x, destination.position.y);
        }
        if (fell.fell == true)
        {
            held = false;
            transform.position = new Vector2(-10, 0);
            Player.transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
            gameObject.GetComponent<SpriteRenderer>().sortingOrder = 2;

        }
    }
}