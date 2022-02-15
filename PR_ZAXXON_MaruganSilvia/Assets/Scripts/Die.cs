using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Restart"))
        {
           // print("funciona");
            SceneManager.LoadScene(1);
        }
        else if (Input.GetButtonDown("Cargar"))
        {
            // print("funciona");
            SceneManager.LoadScene(0);
        }

    }
   
}
