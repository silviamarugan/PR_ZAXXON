
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INST_Generator : MonoBehaviour
{

    //[SerializeField] GameObject obst1; //GameObject que tiene el script
    //[SerializeField] GameObject obst2; //GameObject que tiene el script

    //Posici�n donde se encuentra el Instanciador
    [SerializeField] Transform initPos;

    //Creo un Array que contendr� los diferentes prefabs con obst�culos
    [SerializeField] GameObject[] arrayObst = new GameObject [3];


    //Creo una variable que determinar� qu� obst�culos se instanciar�n
    int level;
    //el intervalo para la corrutina, depender� de la velocidad
    float intervalo;
    //Variable con la distancia entre obst�culos
    [SerializeField] float distanciaEntreObstaculos;
    //Variable para las columnas iniciales
    [SerializeField] float distPrimerObst = 60f; //Lo declaro aqu� para poder cambiarlo en Unity

    //Para calcular el intervalo, necesito saber la velocidad
    float speed;

    //Variable que me permitir� acceder al componente con las variables generales
    VAR_Global initGameScript;

    void Start()
    {
        //Accedo al componente del Game Object. En este ejemplo, lo hago todo en una sola l�nea
        initGameScript = GameObject.Find("VAR_Global").GetComponent<VAR_Global>();

        distanciaEntreObstaculos = 30f;
        intervalo = distanciaEntreObstaculos / initGameScript.Speed;

        //Llamo al m�todo que crea columnas iniciales
        CrearColumnasIniciales();

        //Inicio la Corrutina que instancia los prefabs
        //IMPORTANTE: antes de iniciarla, el intervalo tiene que ser un n�mero v�lido
        StartCoroutine("CrearObstaculos");

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Corrutina que instancia prefabs siguiendo los intervalos
    IEnumerator CrearObstaculos()
    {
        //GameObject obstRandom;
        while (true)
        {
            //Creo un Vector3 que indicar� la posici�n de instanciaci�n
            //El valor X es random, el Z el del objeto de referencia
            Vector3 instPos = new Vector3(Random.Range(-10f, 10f), 0f, initPos.position.z);

            //Creo el n�mero aleatorio para elegir el prefab del Array
            int randomNum;
            //Obtengo el nivel en el que estamos (en cada vuelta de la corrutina)
            level = initGameScript.levelGame;
            //print(level);
            //Seg�n el nivel, instancio unos u otros obst�culos
            if (level == 0)
            {
                randomNum = 0;
            }
            else if (level > 0 && level < 4)
            {
                randomNum = Random.Range(0, 5);
            }
            else
            {
                //En este caso, el n� aleatorio es entre 0 y la longitud del Array
                randomNum = Random.Range(0, arrayObst.Length);
            }

            /*
            //M�todo alternativo y b�sico, sin usar Array
            if(randomNum == 1)
            {
                obstRandom = obst1;
            }
            else
            {
                obstRandom = obst2;
            }
            */

            //Antes de instanciar calculo el intervalo en basde a la velocidad
            intervalo = distanciaEntreObstaculos / initGameScript.Speed;
            //print(intervalo);

            //Instancio el prefab aleatorio en la posici�n calculada
            Instantiate(arrayObst[randomNum], instPos, Quaternion.identity);

            yield return new WaitForSeconds(intervalo);

        }
    }

    //Este m�todo lo he creado para crear unas columnas iniciales
    void CrearColumnasIniciales()
    {

        //El n� de obst�culos es la resta de d�nde estoy menos el primero, partido por la distancia entre obst�culos
        float numColumnasIniciales = (transform.position.z - distPrimerObst) / distanciaEntreObstaculos;
        //Por si acaso sale un n� con decimales lo redondeo con Mathf.Round
        numColumnasIniciales = Mathf.Round(numColumnasIniciales); //Redondeo el n�mero
                                                                  //print("N� de columnas iniciales: " + numColumnasIniciales);

        //Creo un bucle pero en vez de sumar 1 lo hago para que me de la posici�n en Z de cada obst�culo
        //la variable n vale al principio la distancia del primer obst�culo
        //Mientras n no llegue a d�nde estoy en Z, seguir� sumando la distancia entre obst�culos
        //De esta forma n es igual a la posici�n en Z donde tengo que instanciar
        for (float n = distPrimerObst; n < transform.position.z; n += distanciaEntreObstaculos)
        {
            //Creo la posici�n de instanciaci�n, con los valores aleatorios y n en la posici�n en Z
            Vector3 initColPos = new Vector3(Random.Range(-10f, 10f), 0f, n);
            //Creo el obst�culo (en mi caso, al ser un array, creo el primero del array
            Instantiate(arrayObst[0], initColPos, Quaternion.identity);

        }
    }
}
