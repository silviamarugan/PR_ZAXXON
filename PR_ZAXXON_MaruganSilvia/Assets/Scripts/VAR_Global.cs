using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VAR_Global : MonoBehaviour
{

    public float ColSpeed;
    public float RockSpeed;
    public int levelGame;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        Speed = 20;
        ColSpeed = 20f;
        RockSpeed = 40f;
        levelGame = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Speed > 100) { 
        
        }
    }
    public void Morir() {

        Speed = 0f;
        Cols_INST cols_INST = //falta rellenar para muerte de la nave, paramos speed, podemos reiniciar el lvl

    
    
    
    }
}
