using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*
 * Author: [Ihejirika, Chijioke]
 * Last Updated: [11/29/2023]
 * [Controls the players ability to jump]
 */


public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public float jumpForce;
    public float totalScore = 0;
    private float pipePointValue = 5;
    private float thiefPointValue = 3;
    private float coinsValue = 4;
 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerJump();
        PipeScore();
    }

    void playerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log("Jump button has been pressed");
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(1);
        }

        if (other.gameObject.tag == "Coin")
        {
            Debug.Log("Coin has been collected");

            totalScore += coinsValue;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Thief")
        {
            Debug.Log("Thief has hit player");

            totalScore -= thiefPointValue;

            other.gameObject.SetActive(false);
        }
    }

    void PipeScore()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 300f))
        {
            if (hit.collider.tag == "Obstacle")
            {
                totalScore += pipePointValue;
            }
           
        }

        else if (Physics.Raycast(transform.position, Vector3.up, out hit, 300f))
        {
            if (hit.collider.tag == "Obstacle")
            {
                totalScore += pipePointValue;
            }
        }
    }
    
}
