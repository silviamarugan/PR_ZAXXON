using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LVL_array : MonoBehaviour
{

    [SerializeField] GameObject obst; //GameObject que tiene el script
    [SerializeField] Transform initPos; //Variable que contendrá ese script
    [SerializeField] Transform objPos;
    [SerializeField] GameObject[] arrayObst;
    int level;
    float intervalo;
    VAR_Global VAR_Global;
    // Start is called before the first frame update
    void Start()
    {
        VAR_Global = GameObject.Find("InitGame").GetComponent<VAR_Global>();
        intervalo = 1f;
        StartCoroutine("CrearObstaculos");
    }

    // Update is called once per frame
    void Update()
    {
        IEnumerator CrearObstaculos()
        {

            while (true)
            {
                Vector3 instPos = new Vector3(Random.Range(-70f, 70f), 0f, initPos.position.z);
                Instantiate(obst, instPos, Quaternion.identity);
                int randomNum;
                level = VAR_Global.levelGame;
                if (level == 0)
                {
                    randomNum = 0;
                }
                else if (level > 0 && level < 4)
                {
                    randomNum = Random.Range(0, 5);
                }
                else
                {
                    randomNum = Random.Range(0, arrayObst.Length);
                }
                Instantiate(arrayObst[randomNum], instPos, Quaternion.identity);

                yield return new WaitForSeconds(intervalo);
            }
        }
    }
}
