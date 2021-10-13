using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cols_INST : MonoBehaviour
{
   
   
    [SerializeField] GameObject Columns;
    [SerializeField] Transform initPOS;
    float intervalo;
    // Start is called before the first frame update
    void Start()
    {
        intervalo = 0.4f;
        StartCoroutine("COLcreator");
        

    }

    // Update is called once per frame
    void Update()
    {
     
    }
    IEnumerator COLcreator()
    {
        while (true)
        {

            //float rotationVAL = Random.Range(0f, 360f); //rotacion de las columnas 
            Vector3 instPOS = new Vector3(Random.Range(-70f, 70f), 14f, initPOS.position.z);

           

            //Instantiate(Columns, instPOS, Quaternion.Euler(0f,0f, rotationVAL)); //en caso de querer columnas fijas usar -> Quaternion.identity
            Instantiate(Columns, instPOS, Quaternion.identity);

            // Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f)) para rotar las columnas. 
            yield return new WaitForSeconds(intervalo);
        }
          
        



    }
}
