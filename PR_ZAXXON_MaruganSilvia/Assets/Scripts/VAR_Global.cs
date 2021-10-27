using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VAR_Global : MonoBehaviour
{

    public float ColSpeed;
    public float RockSpeed;
    public int levelGame;
   static public float Speed;
    static float score;
    public bool alive;
    [SerializeField] float maxSpeed;
    [SerializeField] Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 30;
        ColSpeed = 40f;
        RockSpeed = 50f;
        levelGame = 1;
      //  score = 000000000;
        maxSpeed = 100f;
        alive = true;
        scoreText.text = "000" + score + "points";
        int y = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Speed < maxSpeed && alive == true) {
            Speed += 0.001f;
        }

        float time = Time.time;
     //   print(Mathf.Round(time));
        score = Mathf.Round(time) * Speed;
        print(Mathf.Round(score));


    }
    public void Morir() {

        Speed = 0f;
        Cols_INST cols_INST = GameObject.Find("Cols_INST").GetComponent<Cols_INST>();
        cols_INST.SendMessage("Parar");//falta rellenar para muerte de la nave, paramos speed, podemos reiniciar el lvl


        SceneManager.LoadScene(2);

    }
}
