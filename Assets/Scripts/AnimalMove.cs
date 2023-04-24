using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMove : MonoBehaviour
{
    [SerializeField]
    float animalSpeed = 10 ;
    float maxZbound =  12;
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * animalSpeed);
        Destroy(gameObject, 4);

        if(transform.position.z > maxZbound )
        {
            Time.timeScale = 0;
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
