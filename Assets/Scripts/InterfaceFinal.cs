using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textThrown;
    public Text textDestroyed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textThrown.text = "Number of Stones: " + GameManager.currentNumberStonesThrone;
        textDestroyed.text = "Destroyed: " + GameManager.currentNumberStonesDestroyed;
    }

    public void Click()
    {
        SceneManager.LoadScene("Awake");
    }
}
