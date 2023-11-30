using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
