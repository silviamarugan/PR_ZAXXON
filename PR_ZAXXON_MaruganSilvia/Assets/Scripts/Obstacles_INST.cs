using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles_INST : MonoBehaviour
{
    float intervalo;
    float distance;
    [SerializeField] GameObject Columns;
    [SerializeField] Transform initPOS;
    
    // Start is called before the first frame update
    void Start()
    {
        
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

          
            Vector3 instPOS = new Vector3(Random.Range(-40f, 40f), 0f, initPOS.position.z);

            

            Instantiate(Columns, instPOS , Quaternion.identity);
            intervalo = 1f;
              yield return new WaitForSeconds(intervalo);
        }
          




    }
}
