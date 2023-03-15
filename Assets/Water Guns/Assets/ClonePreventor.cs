using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonePreventor : MonoBehaviour{

    public GameObject Player1;
    public GameObject Player2;

    public int P1Life;
    public int P2Life;
    public GameObject gameOver;
    public GameObject[] P1Triangles;
    public GameObject[] P2Triangles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        if (P1Life <= 0)
        {
        Player1.SetActive(false);
        gameOver.SetActive (true);
        }
        if (P2Life <= 0)
        {
        Player2.SetActive(false);
        gameOver.SetActive (true);
        }

    }
    public void HurtP1()
    {
        P1Life -= 1;
        for(int i = 0; i < P1Triangles.Length; i++)
        {
            if(P1Life > i)
            {
                P1Triangles[i].SetActive(true);
            } else {
                P1Triangles[i].SetActive(false);
            }
        }
    }

    public void HurtP2()
    {
        P2Life -= 1;
                for(int i = 0; i < P2Triangles.Length; i++)
        {
            if(P1Life > i)
            {
                P2Triangles[i].SetActive(true);
            } else {
                P2Triangles[i].SetActive(false);
            }
        }
    }
}