using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class S8_DestruyeObjetos2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text_puntacion;
    int cont = 0;
    private void OnCollisionEnter(Collision other){
        GameObject objeto = other.gameObject;
        if(!objeto.CompareTag("NoRomper")){
            cont++;
            text_puntacion.text = cont.ToString();
            Destroy(objeto);
        }
    }
}
