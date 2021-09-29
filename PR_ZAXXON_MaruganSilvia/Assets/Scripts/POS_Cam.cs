using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POS_Cam : MonoBehaviour
{
    // Start is called before the first frame update

                                    //VARIABLES ANTIGUAS

                                    /*  [SerializeField] Transform PlayerPOS;
                                      [SerializeField] float DistanciaPLayer = 10f;
                                      [SerializeField] float AlturaCAM = 5f; 
                                       Vector3 CamPOS; */

                                    //FIN VARIABLES ANTIGUAS

    [SerializeField] Transform playerPos;
    float AlturaCAM = 3f;
    [SerializeField] float smoothVelocity = 0.3F;
    [SerializeField] Vector3 camaraVelocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
                                    //CODIGO ANTIGUO

                                    /* float newPosY = PlayerPOS.position.y + AlturaCAM;
                                   float newPosZ = PlayerPOS.position.z - DistanciaPLayer;


                                   transform.position = CamPOS = new Vector3(0f, newPosY, newPosZ); */
                                    //FIN CODIGO ANTIGUO

        //SEGUIMIENTO CAMARA
        float newPosY = playerPos.position.y + AlturaCAM;
        transform.position = new Vector3(playerPos.position.x, newPosY, playerPos.position.z - 10);
        // FIN SEGUIMIENTO CAMARA

        Vector3 targetPosition = new Vector3(transform.position.x, playerPos.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref camaraVelocity, smoothVelocity);
    }

}
