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
        
        bulletBill();
        
    }

    //Move to goingLeft
    private void bulletBill()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    
}
