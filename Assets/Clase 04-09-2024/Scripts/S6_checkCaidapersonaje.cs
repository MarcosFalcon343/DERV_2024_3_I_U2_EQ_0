using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6_checkCaidapersonaje : MonoBehaviour
{
    float valor_y;
    [SerializeField] Transform spanwPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        valor_y = transform.position.y; //obtenemos la posicion en y del objeto
        if (valor_y < 0) //si el objeto cae mas de 10 unidades en y
        {
            transform.position = spanwPoint.position;  //lo regresamos a la posicion 0,0,0
        }
    }
}
