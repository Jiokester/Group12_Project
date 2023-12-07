using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Author: Riley Conlon
 * Date: 12/7/23
 * Function: Code the Bullet Bill enemy
 */

public class BulletBill : MonoBehaviour
{
    public int speed;


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
