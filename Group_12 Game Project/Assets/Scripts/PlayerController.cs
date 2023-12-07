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
    private float hitPoints = 0;

    public bool isBlinking;
    public float blinkTime = .3f;
 


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
            if (isBlinking == false)
            {
                //Prevents instadeath if health is greater than 0
                if (hitPoints > 0)
                {
                    StartCoroutine(Blink());
                    hitPoints--;
                }
                else 
                {
                    if (hitPoints == 0)
                    {
                        SceneManager.LoadScene(3);
                        
                    }
                    
                }
            }
            else
            {
                //Nothing if Blinking
            }
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
        //Riley
        //Health Pickup
        if (other.gameObject.tag == "Health")
        {
            Debug.Log("Health Gained");

            hitPoints++;

            other.gameObject.SetActive(false);
        }

        ///Jioke
        //Portal Transportation to next scene

        if (other.gameObject.tag == "Portal")
        {
            ///Load the next scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            Debug.Log("Player has been teleported to the next scene");
        }

        if (other.gameObject.tag == "Bounds")
        {
            SceneManager.LoadScene(3);
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
    //Blinking coroutine 
    public IEnumerator Blink()
        {
            isBlinking = true;
            for (int index = 0; index < 12; index++)
            {
                if (index % 2 == 0)
                {
                    GetComponent<MeshRenderer>().enabled = false;
                    
                }
                else
                {
                    GetComponent<MeshRenderer>().enabled = true;
                }
                yield return new WaitForSeconds(blinkTime);

            }
            GetComponent<MeshRenderer>().enabled = true;
            isBlinking = false;
        }
}
