using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_Cols : MonoBehaviour
{
    [SerializeField] GameObject initCol;
    VAR_Global vAR_Global;
    float speed;
   
    // Start is called before the first frame update
    void Start()
    {
        initCol = GameObject.Find("vAR_Global");
        vAR_Global = initCol.GetComponent<VAR_Global>();
      
    }

    // Update is called once per frame
    void Update()
    {
        speed = vAR_Global.ColSpeed;

        transform.Translate(Vector3.back * Time.deltaTime * speed);
        float posZ = transform.position.z;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            bool slow = false;
            //  rend.material.shader = Shader.Find("Highlight");
            //  rend.material.SetColor("Highlight", Color.blue);

            slow = true;
            print("Slow");
            if (slow == true)
            {
                speed = 8f;

            }
        }

        if (posZ < -40)
        {
            Destroy(gameObject);
        }
    }
}
