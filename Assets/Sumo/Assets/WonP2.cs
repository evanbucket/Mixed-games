using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WonP2 : MonoBehaviour
{

    public Flag2 flag;
    private Transform destination;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2 (1000, 1000);
    }

    // Update is called once per frame
    void Update()
    {
        if(flag.goal == true)
        {
            destination = GameObject.FindGameObjectWithTag("Cam").GetComponent<Transform>();
            transform.position = new Vector2 (destination.position.x, destination.position.y);

        }
    }
}
