using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COL_Creator : MonoBehaviour
   

{
    [SerializeField] GameObject Columns;
    [SerializeField] Transform initPOS;
   

    float distance; 


    // Start is called before the first frame update
    void Start()
    {
       
        Vector3 newPOS = initPOS.position;
        // distance = 15f;
          
      


        //Num columnas. Transform y rotate.
        for (int n = 0; n < 10; n++) 
        {
            Vector3 displacement = new Vector3(Random.Range(5f, 15f), 0f, 0f);
            Instantiate(Columns, newPOS, Quaternion.identity);
            newPOS = newPOS + displacement;

                  

        }
        //FIN Num columnas. Transform y rotate.



        //ESCALA RANDOM


        //get random size (need to be Vector3 not Vector2) if you want to just change x scale 


        //set it to the scale of previously instantiated platform 

        //FIN ESCALA RANDOM


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
