using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POS_Cam : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform PlayerPOS;
    [SerializeField] float DistanciaPLayer = 10f;
    [SerializeField] float AlturaCAM = 10f;

    Vector3 CamPOS;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float newPosY = PlayerPOS.position.y + AlturaCAM;
        float newPosZ = PlayerPOS.position.z - DistanciaPLayer;
       
      
        transform.position = CamPOS = new Vector3(0f, newPosY, newPosZ);
    }

}
