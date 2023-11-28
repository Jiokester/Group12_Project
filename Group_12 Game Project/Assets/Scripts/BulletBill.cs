using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBill : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletBill();
    }
    private void bulletBill()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

}
