using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S7_Contador : MonoBehaviour
{
    [SerializeField] ChangeScene auxiliar;
    [SerializeField] S8_DestruyeObjetos2 aux_cont_enemigos;
    int cont;
    [SerializeField] TextMeshProUGUI texto_contador;
    void Start()
    {
        cont = 10;
        StartCoroutine(currutina_contador());
    }

    IEnumerator currutina_contador(){
        while(cont > 0){
            cont--;
            texto_contador.text = cont.ToString();
            yield return new WaitForSeconds(0.5f); 
        }
        int puntuacion =  aux_cont_enemigos.cont;
        auxiliar.cambioEscena(2, puntuacion);
    }
}
