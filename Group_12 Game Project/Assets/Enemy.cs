using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //speed variable
    public float speed;

    //Top and Bottom point variables 
    private Vector3 topPos;
    private Vector3 bottomPos;
    public GameObject topPoint;
    public GameObject bottomPoint;

    //T/F goingUp
    public bool goingUp;

    //Left point variables
    private Vector3 leftPos;
    public GameObject leftPoint;

    //spawnpoint
    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        topPos = topPoint.transform.position;
        bottomPos = bottomPoint.transform.position;
        leftPos = leftPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }


    /// <summary>
    /// allows the enemy to move up and down
    /// </summary>
    private void EnemyMove()
    {
        if (this.gameObject.tag == "Enemy")
        {
            if (goingUp == true)
            {
                if (transform.position.y >= topPos.y)
                {
                    goingUp = false;
                }
                else
                {
                    transform.position += Vector3.up * speed * Time.deltaTime;
                }
            }
            else
            {
                if (transform.position.y <= bottomPos.y)
                {
                    goingUp = true;
                }
                else
                {
                    transform.position += Vector3.down * speed * Time.deltaTime;
                }
            }
        }    
    }

    //Horizontal enemy movement and spawning
    private void bulletBill()
    {
        if (this.gameObject.tag == "HEnemy")
        {

        }
    }
}
