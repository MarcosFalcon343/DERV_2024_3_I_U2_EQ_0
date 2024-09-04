using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1_Movimiento_Forma1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        float constante = 5;
        if(Input.GetKey(KeyCode.W))
        {
            //transform.Translate(transform.forward);
            transform.Translate(constante * Time.deltaTime * new Vector3(0, 0, 1));
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(constante * -1 * Time.deltaTime * new Vector3(0, 0, 1));
        }
    }
}
