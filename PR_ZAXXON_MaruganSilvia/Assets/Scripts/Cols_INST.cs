using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cols_INST : MonoBehaviour
{


    [SerializeField] GameObject[] OBS = new GameObject[2];
    [SerializeField] Transform initPOS;
    float intervalo01;
    float intervalo02;
   


    // Start is called before the first frame update
    void Start()
    {

        intervalo01 = 0.4f;
        intervalo02 = 0.6f;
        
        StartCoroutine("COLcreator");
        StartCoroutine("ROCKcreator");
       


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void parar()
    {

        StopCoroutine("COLcreator");
        StopCoroutine("ROCKcreator");
        
    }
    IEnumerator COLcreator()
    {
        while (true)
        {
            //  int r = Random.Range (0, OBS.Length) ;
            //float rotationVAL = Random.Range(0f, 360f); //rotacion de las columnas 


            Vector3 instPOS = new Vector3(Random.Range(-40f, 40f), 17f, initPOS.position.z);


            Instantiate(OBS[0], instPOS, Quaternion.identity);

            // Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f)) para rotar las columnas. 
            yield return new WaitForSeconds(intervalo01);

        }

    }




   


    IEnumerator ROCKcreator()
        {
            while (true)
            {
                // int r = Random.Range(0, OBS.Length);

                float rotationVAL = Random.Range(0f, 180f); //rotacion
                Vector3 instPOS = new Vector3(Random.Range(-20f, 20f), Random.Range(10f, 35f), initPOS.position.z);



                Instantiate(OBS[1], instPOS, Quaternion.Euler(0f, 0f, rotationVAL));

                // Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f)) para rotar las columnas. 
                yield return new WaitForSeconds(intervalo02);

            }

        }
    }


