using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("SnakeGame", LoadSceneMode.Single);
    }
}
