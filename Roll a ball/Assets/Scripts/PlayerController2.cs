using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController2 : MonoBehaviour
{

    public float speed;

    public float attach = 0;
  

    private Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            

        }
        

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
            attach = 1;
            
            

        }


    }


}