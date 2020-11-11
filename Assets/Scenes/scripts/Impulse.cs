using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{

    public GameObject stone;
    public float fireRate = .5f;

    //private float nextFire = .0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ThrowStone());
    }

    // Update is called once per frame
    void Update()
    {
        //if(Time.time > nextFire)
        //{
        //    nextFire = Time.time + fireRate;
        //    Instantiate(stone, transform.position, Random.rotation);
        //}
    }

    IEnumerator ThrowStone()
    {
        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            Instantiate(stone, transform.position, Random.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
