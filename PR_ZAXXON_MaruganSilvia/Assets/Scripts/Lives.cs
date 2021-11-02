using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Image lives;
    [SerializeField] Sprite[] livesArray = new Sprite [6];
    [SerializeField] int vidas;
    int spritepos;
    void Start()
    {

        vidas = livesArray.Length;
        lives.sprite = livesArray[spritepos];

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Chocar();

        }
    }
    public void Chocar() {
        vidas--;
        if (vidas > 0)
        {
            spritepos++;
            lives.sprite = livesArray[spritepos];

        }
        else if(vidas < 0) {

            print("muerte");
        }
    
    
    
    }
}
