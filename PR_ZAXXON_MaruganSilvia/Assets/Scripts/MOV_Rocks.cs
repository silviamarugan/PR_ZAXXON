using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOV_Rocks : MonoBehaviour
{
    [SerializeField] GameObject initRock;
    VAR_Global vAR_Global;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        initRock = GameObject.Find("GlobalVARS");
        vAR_Global = initRock.GetComponent<VAR_Global>();

    }

    // Update is called once per frame
    void Update()
    {
        speed = vAR_Global.RockSpeed;

        transform.Translate(Vector3.back * Time.deltaTime * speed);
        float posZ = transform.position.z;


        if (posZ < -40)
        {
            Destroy(gameObject);
        }
    }
}
