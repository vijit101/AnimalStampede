using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    float horizontalInput;
    public float MoveSpeed,minXbound,maxXbound;
    public GameObject food;
    // Update is called once per frame
    void Update()
    {
        
        horizontalInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * MoveSpeed*Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minXbound, maxXbound), transform.position.y, transform.position.z);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(food,transform.position,transform.rotation);
        }
    }
}
