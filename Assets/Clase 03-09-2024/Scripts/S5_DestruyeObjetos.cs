using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_DestruyeObjetos : MonoBehaviour
{
    private void OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        if(!objeto.CompareTag("NoRomper")){
            Destroy(objeto);
        }
    }
}
