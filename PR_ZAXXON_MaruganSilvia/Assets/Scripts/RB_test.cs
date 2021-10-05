using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_test : MonoBehaviour
{

    [SerializeField] GameObject nave;
    Rigidbody rb; 
    // Start is called before the first frame update
    void Start()
    {
        rb = nave.GetComponent<Rigidbody>();
        rb.drag = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        float DesplY = Input.GetAxis("Vertical");
        rb.drag = DesplY * 20f;
    }
}
