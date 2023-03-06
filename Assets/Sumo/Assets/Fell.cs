using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fell : MonoBehaviour
{
    public GameObject Player;
    public bool fell;

   
   void Update()
   {

        if((Player.transform.position.x < -12.5) || (Player.transform.position.x > 12.5) || (Player.transform.position.y < -6.3) || (Player.transform.position.y > 6.3))
        {
            fell = true;
        }
        else
        {
            fell = false;
        }

        if (fell == true)
        {
            Player.transform.rotation = Quaternion.LookRotation(new Vector3(0, 0, 0));
            Player.transform.position = new Vector2(-8, 0);
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);

        }


   }
}
