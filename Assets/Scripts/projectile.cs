using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    float Speed = 40;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Animal")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
       
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        Destroy(gameObject, 4);
    }
}
