using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class M2_ControlEsfera : MonoBehaviour
{
    [SerializeField] List<GameObject> spawns;

    [SerializeField] M1_HandlerUI m1_Handler;
    int index;
    float tiempo_en_collision;

    private void OnCollisionEnter(Collision other){
         GameObject objeto = other.gameObject;
         if(objeto.CompareTag("Player")){
            mueveEsfera();
            m1_Handler.agregaPunto();
        }
        tiempo_en_collision = 0;
    }

    private void OnCollisionStay(Collision Other){
        tiempo_en_collision += Time.deltaTime;
        //Debug.Log(tiempo_en_collision);
        if(tiempo_en_collision > 0.5f){
            mueveEsfera();
        }
    }

    private void mueveEsfera(){
        index = Random.Range(0, spawns.Count);
        transform.position = spawns[index].transform.position;
    }
}
