using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public PlayerLocater selector;
    private bool coroutineAllowed;
    // Start is called before the first frame update
    void Start()
    {
        coroutineAllowed = true;
        
    }

    // Update is called once per frame
    private void OnMouseOver()
    {
        if (coroutineAllowed){

            StartCoroutine("StartPulsing");
        }

    }

    void OnMouseDown() 
    {
     StartCoroutine("Move");
    
 
    }

    private IEnumerator StartPulsing()
    {
        coroutineAllowed = false;

        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x + 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y + 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z + 0.025f, Mathf.SmoothStep(0f, 1f, i)))

            );
            yield return new WaitForSeconds(0.025f);

        }


        for (float i = 0f; i <= 1f; i += 0.1f)
        {
            
            transform.localScale = new Vector3(
                (Mathf.Lerp(transform.localScale.x, transform.localScale.x - 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.y, transform.localScale.y - 0.025f, Mathf.SmoothStep(0f, 1f, i))),
                (Mathf.Lerp(transform.localScale.z, transform.localScale.z - 0.025f, Mathf.SmoothStep(0f, 1f, i)))

            );
            yield return new WaitForSeconds(0.025f);

        }
    
        coroutineAllowed = true;




    }

    private IEnumerator Move(){

        
     selector.select = 3;
     transform.position = new Vector2 (1000, 0);
     yield return new WaitForSeconds(0.1f);     
     selector.select = 1;
           
        yield return null;


    }



}
