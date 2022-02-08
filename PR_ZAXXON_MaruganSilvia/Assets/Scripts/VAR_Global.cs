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
    GameObject GameOver;
    Canvas GameOverCanvas;
    [SerializeField] float maxSpeed;
    [SerializeField] Text score;


    [SerializeField] Image lives;
    [SerializeField] Sprite[] livesArray = new Sprite[6];
    private int maxlives = 6;
    public int currlives;

    [SerializeField] Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        



        currlives = maxlives;
        Speed = 30;
        ColSpeed = 40f;
        RockSpeed = 50f;
      //  levelGame = 0;
      //  score = 000000000;
        maxSpeed = 100f;
        alive = true;
      
        int y = SceneManager.GetActiveScene().buildIndex;



        maxlives = livesArray.Length;
        lives.sprite = livesArray[currlives];

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
        Cols_INST cols_INST = GameObject.Find("COLS_gameOBJ").GetComponent<Cols_INST>();
       cols_INST.SendMessage("Parar");
       
       
        //Desactivo el Grupo que contiene la nave
        GameObject.Find("NAVE").SetActive(false);

         Invoke("MostrarGameOver", 2f);

      //  SceneManager.LoadScene(5);



        //SceneManager.LoadScene(2);


    }
    void MostrarGameOver()
    {
        //Muestro el menú GameOver
        SceneManager.LoadScene(5);
        //Selecciono el botón de volver


    }
    public void Chocar()
    {
        if (alive == true)
        {
            currlives--;
            //print("hit");
            if (currlives > 0)
            {
              
                lives.sprite = livesArray[currlives];
            }
            else
            {
                alive = false;
                Morir();


            }


        }
    }


    public void Invencibility() {

        Invoke("PararInvencib", 3f);

    }
    void PararInvencib()
    {



    }
}
