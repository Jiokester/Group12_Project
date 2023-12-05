using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Author: [Ihejirika, Chijioke]
 * Last Updated: [12/5/2023]
 * [Objects will move towards the left f the screen and be deletd when they are offscreen]
 */
public class GoingLeft : MonoBehaviour
{
    
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < -20)
        {
            Destroy(gameObject);
        }
    }
}
