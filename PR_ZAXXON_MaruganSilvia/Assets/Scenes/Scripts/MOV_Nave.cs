using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_Nave : MonoBehaviour
{

    Vector3 playerPos = new Vector3(0f, 0.40f, -23f);
    float speed = 20f;





    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPos;
        speed = 20f;

    }

    // Update is called once per frame
    void Update()
    {





        //DASH
        bool dash = false;
        if (Input.GetKey(KeyCode.Space))
        {
            dash = true;
            print("Dash");
            if (dash == true)
            {
                speed = 30f;
            }

        }
        //FIN DASH

        //ESCUDO
        if (Input.GetKey(KeyCode.LeftControl))
        {
            print("Invencibility");
        }
        //FIN ESCUDO

        //CURA
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            print("HealthUP");
        }
        //FIN CURA

        //SLOW
        bool slow = false;
       
        if (Input.GetKey(KeyCode.LeftShift))
        {

            slow = true;
            print("Slow");
            if (slow == true) {
                speed = 12f; 

            }
        }
        //FIN SLOW

        //MOV NAVE
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        

        //FIN MOV NAVE 
    }
}
