using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
   public float power = 10f;
   public Rigidbody2D rb;
   public Transform PlayerPosition;


   public Vector2 minPower;
   public Vector2 maxPower;
   public Vector3 check;
   public bool help;
   

   TrajectoryLine tl;

   Camera cam;
   Vector2 force;
   Vector3 startPoint;
   Vector3 endPoint;
 

   public PlayerLocater selector;


 
   IEnumerator stopped()
   {
      selector.select = 1;
      while (selector.select == 1)
      {
         if (GetComponent<Rigidbody2D>().velocity.magnitude > 0)
         {
         selector.select = 1;
         
         } 
         if (GetComponent<Rigidbody2D>().velocity.magnitude == 0)
         {
            
            selector.select = 2;
         }
         yield return null;
      }

           
   }
   



   private void Start()
   {
      cam = Camera.main;
      tl = GetComponent<TrajectoryLine>();
   
        
        
   }

    private void Update()
    {
        if (selector.select == 1)
        {
            if (GetComponent<Rigidbody2D>().velocity.magnitude == 0)
            {
               
                  selector.select = 1;
               
                  
               if (Input.GetMouseButtonDown(0)) 
               {
                  startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                  startPoint.z = 15;
            
               }  

               if (Input.GetMouseButton(0))
               {
                  Vector3 currentPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                  currentPoint.z = 15;
                  tl.RenderLine(startPoint, currentPoint);
               }

               if (Input.GetMouseButtonUp(0))
               {
                  endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                  endPoint.z = 15;

                  force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
                  rb.AddForce(force * power, ForceMode2D.Impulse);
                  tl.EndLine();
                  
                  StartCoroutine(stopped());
                  
               }
         
        }
      }
      
        

    } 

}
