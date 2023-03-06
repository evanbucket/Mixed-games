using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{


    public PlayerLocater selector;
    // Start is called before the first frame update
    void Awake()
    {
        selector.select = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (selector.select != 0)
        {

            transform.position = new Vector2 (1000, 0);

        }
    }
}
