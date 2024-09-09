using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class S7_Contador : MonoBehaviour
{
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
    }
}
