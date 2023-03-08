using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SumoSelect : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Sumo", LoadSceneMode.Single);
    }
}
