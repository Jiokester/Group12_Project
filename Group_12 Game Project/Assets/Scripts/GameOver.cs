using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }  

    public void SwtichScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
