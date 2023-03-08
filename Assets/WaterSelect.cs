using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterSelect : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("", LoadSceneMode.Single);
    }
}
