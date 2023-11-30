using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: [Ihejirika, Chijioke]
 * Last Updated: [11/29/2023]
 * [When the player dies, the game s over]
 */


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
