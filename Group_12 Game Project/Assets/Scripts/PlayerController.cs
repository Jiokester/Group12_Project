using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRb;
    public float jumpForce;
    public int coinsCollected;
    public float totalScore = 0;
    private float pipePointValue = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerJump();
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
            coinsCollected++;
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Thief")
        {
            Debug.Log("Thief has hit player");
        }
    }

    void PipeScore()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 300f))
        {

            totalScore += pipePointValue;
        }
    }
}
