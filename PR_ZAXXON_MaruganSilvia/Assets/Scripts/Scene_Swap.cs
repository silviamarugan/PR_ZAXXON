using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Swap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IniciarJuego()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(1);
        }

    }
}
