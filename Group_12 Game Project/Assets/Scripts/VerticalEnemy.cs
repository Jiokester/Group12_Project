using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Riley Conlon
 * Date:12/7/23
 * Function:Allow the Vertical Enemy to move up and down
 */

public class VerticalEnemy : MonoBehaviour
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

    //spawnpoint
    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        topPos = topPoint.transform.position;
        bottomPos = bottomPoint.transform.position;
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
