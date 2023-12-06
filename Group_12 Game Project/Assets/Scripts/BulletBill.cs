using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Riley Conlon
 * Date: 12/5/23
 * Function: Code the Bullet Bill enemy
 */

public class BulletBill : MonoBehaviour
{
    public int speed;

    //public GameObject spawnPoint;

    public GameObject topPoint;
    public GameObject bottomPoint;
    public Vector3 topPos;
    public Vector3 bottomPos;

    public bool goingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        topPos = topPoint.transform.position;
        bottomPos = bottomPoint.transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        //Move to goingLeft script
        //bulletBill();
        VerticalEnemy();
    }

    //Move to goingLeft
    private void bulletBill()
    {
        //transform.position += Vector3.left * speed * Time.deltaTime;
    }

    public void VerticalEnemy()
    {
        if (goingUp == true)
        {
            if (transform.position.y >= topPos.y)
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
                goingUp = false;

            }
            else
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
                goingUp = true;
            }
        }
        else
        {
            if (transform.position.y <= bottomPos.y)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
                goingUp = true;
            }
            else
            {
                transform.position += Vector3.down * speed * Time.deltaTime;
                goingUp = false;
            }
        }

    }
}
