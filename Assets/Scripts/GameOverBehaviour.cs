using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverBehaviour : MonoBehaviour
{
    private void Update()
    {
        if (Input.anyKeyDown)
            SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}