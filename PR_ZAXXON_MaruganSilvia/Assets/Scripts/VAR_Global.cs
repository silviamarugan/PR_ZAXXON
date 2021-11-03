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
    static float scorepoints;
    public bool alive;
    [SerializeField] float maxSpeed;
    [SerializeField] Text score;

    [SerializeField] Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 30;
        ColSpeed = 40f;
        RockSpeed = 50f;
      //  levelGame = 0;
      //  score = 000000000;
        maxSpeed = 100f;
        alive = true;
      
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
        scorepoints = Mathf.Round(time) * Speed;

       // levelText.text = "NIVEL: " + levelGame.ToString();

        score.text = "000" + (Mathf.Round(scorepoints)) + " points";
        if (scorepoints > 500 && scorepoints < 1000)
        {
           // levelGame = 1;
        }
        else if (scorepoints > 1000)
        {
           // levelGame = 2;
        }
    }
    public void Morir() {
        alive = false;
        Speed = 0f;
        Cols_INST cols_INST = GameObject.Find("Cols_INST").GetComponent<Cols_INST>();
        cols_INST.SendMessage("Parar");
        
        GameObject.Find("Nave_pref").SetActive(false);



        SceneManager.LoadScene(2);

    }
    
}
