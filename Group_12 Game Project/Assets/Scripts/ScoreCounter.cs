using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


/*
 * Author: [Ihejirika, Chijioke]
 * Last Updated: [11/29/2023]
 * [Keeps track of players score]
 */
public class ScoreCounter : MonoBehaviour
{
    public TMP_Text scoreText;
    public PlayerController playerController;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + playerController.totalScore.ToString();
    }
        
}
