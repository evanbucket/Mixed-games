using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour {

    public float waterSpeed;
    public float direction = 1;
    public string parentName;


    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start() { 
        rb = GetComponent<Rigidbody2D> ();
        rb.velocity = new Vector2 (direction * waterSpeed * transform.localScale.x, 0);
    }

    // Update is called once per frame
    void Update() {
        
        //Debug.Log(direction);
        //rb.velocity = new Vector2 (direction * waterSpeed * transform.localScale.x, 0);
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.name != parentName) {
            gameObject.SetActive(false);
            gameObject.transform.position = gameObject.transform.parent.position;

        if(other.tag == "Player1")
        {
            FindObjectOfType<ClonePreventor>().HurtP1();
        }
        if(other.tag == "Player2")
        {
            FindObjectOfType<ClonePreventor>().HurtP2();
        }
            //Destroy(gameObject);
        }
        
    }

}
