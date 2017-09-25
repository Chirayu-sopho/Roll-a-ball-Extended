using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController1 : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
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
            other.gameObject.SetActive(true);
            count = count + 1;
            SetCountText();
            other.gameObject.transform.position = new Vector3(Random.Range(-4.5f,4.55f), 0.5f, Random.Range(-10f, 10f));
        }
        if (other.gameObject.CompareTag("Don't Pick Up"))
        {
            other.gameObject.SetActive(true);
            count = count - 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winText.text = "You Win!";
        }
        else
        {
            winText.text = "You Lose!";
        }
    }
}