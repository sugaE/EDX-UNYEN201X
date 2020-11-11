using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    public float forceValue;
    public float jumpValue;

    private Rigidbody rb;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
        //0,
        //Input.GetAxis("Vertical") * speed * Time.deltaTime);

        //desktop
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y) < .01f)
        {
            rb.AddForce(new Vector3(0, 1, 0) * jumpValue, ForceMode.Impulse);

            audioSource.Play();
        }

        //mobile
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began && Mathf.Abs(rb.velocity.y) < .01f)
            {
                rb.AddForce(new Vector3(0, 1, 0) * jumpValue, ForceMode.Impulse);

                audioSource.Play();
            }

        }
        

    }

    //sync with physics engine
    private void FixedUpdate()
    {
        //desktop
        rb.AddForce(new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")) * forceValue);

        //mobile
        rb.AddForce(new Vector3(
            -Input.acceleration.y,
            0,
            Input.acceleration.x 
            ) * forceValue);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            print("collision");
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
            print("enter");
    }


}
