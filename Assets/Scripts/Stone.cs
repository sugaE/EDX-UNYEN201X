using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{

    //public float impulseForse = 10.0f;
    public GameObject explosion;

    private const float yOie = -30.0f;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().AddForce(Vector3.up * impulseForse, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yOie)
        {
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity), 2.0f);
        Destroy(gameObject);
        GameManager.currentNumberStonesDestroyed++;
    }
}
