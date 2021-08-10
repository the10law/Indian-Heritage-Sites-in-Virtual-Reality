using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        Invoke("delayback", 5);
    }
    public void delayback()
    {
        
            SceneManager.LoadScene("sites");

    }
}
