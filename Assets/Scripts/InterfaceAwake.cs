using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // initialize
        GameManager.currentNumberStonesDestroyed = 0;
        GameManager.currentNumberStonesThrone = 0;
    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public void Click()
    {
        // destroy release current scene;
        SceneManager.LoadScene("stoneGame");
    }
}
