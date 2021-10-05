using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_Nave : MonoBehaviour
{

    Vector3 playerPos = new Vector3(0f, 0.40f, -23f);
    public float speed = 20f;
    float maxX = 73f;
    float maxY = 35f;
    float maxGRND = 1f;
   

    // Start is called before the first frame update
    void Start()
    {
        transform.position = playerPos;
        speed = 20f;

    }

    // Update is called once per frame
    void Update()
    {

      
        Renderer rend = GetComponent<Renderer>();

        //Restriccion en X
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -maxX, maxX);
        transform.position = pos;
        //Fin restriccion X

        //Restriccion en Y
        pos.y = Mathf.Clamp(pos.y, maxGRND, maxY);
        transform.position = pos;
        //Fin restriccion Y

                                                                                 // POWER UPS

        //DASH (input en "SPACE" y "X" de mando)
        bool dash = false;
        if (Input.GetKey(KeyCode.Space))
        {
            rend.material.shader = Shader.Find("Highlight");
            rend.material.SetColor("Highlight", Color.magenta);
            dash = true;
            print("Dash");
            if (dash == true)
            {
                speed = 40f;
            }

        }
        //FIN DASH 

        //ESCUDO (input en "CTRL" y "Y" de mando)
        if (Input.GetKey(KeyCode.LeftControl))
            rend.material.shader = Shader.Find("Highlight");
        rend.material.SetColor("Highlight", Color.clear);
        {
            print("Invencibility");
        }
        //FIN ESCUDO

        //CURA (input en "ALT" y "A" de mando)
        if (Input.GetKey(KeyCode.LeftAlt))
            rend.material.shader = Shader.Find("Highlight");
        rend.material.SetColor("Highlight", Color.green);
        {
            print("HealthUP");
        }
        //FIN CURA

        //SLOW (input en "CTRL" y "B" de mando)
        bool slow = false;
       
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rend.material.shader = Shader.Find("Highlight");
            rend.material.SetColor("Highlight", Color.blue);

            slow = true;
            print("Slow");
            if (slow == true) {
                speed = 8f; 

            }
        }
        //FIN SLOW

                                                                                 // FIN POWER UPS

        //MOV NAVE
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * speed);
        transform.Translate(Vector3.up * Time.deltaTime * Input.GetAxis("Vertical") * speed);
        
        //FIN MOV NAVE 
    }
}
