using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocater : MonoBehaviour
{
    private Transform destination;
    public float distance = 0.2f; 
    public int select = 0;
   


    // Start is called before the first frame update
    void Start()
    {
        destination = GameObject.FindGameObjectWithTag("PlayerOne").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (select == 1)
        {
            destination = GameObject.FindGameObjectWithTag("PlayerOne").GetComponent<Transform>();
            transform.position = new Vector2 (destination.position.x, destination.position.y);
        }
        if (select == 2)
        {
            destination = GameObject.FindGameObjectWithTag("PlayerTwo").GetComponent<Transform>();
            transform.position = new Vector2 (destination.position.x, destination.position.y);

        }
        
    }
}
