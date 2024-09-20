using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionTriggers : MonoBehaviour
{
    [SerializeField]GameObject plancha_resultado;
    Renderer rend;
    Material material;
    Material color_Original;
    public void Start(){
        rend = GetComponent<Renderer>();
        material = rend.material;
        color_Original = plancha_resultado.GetComponent<Renderer>().material;
    }
    private void OnTriggerEnter(Collider other){
        plancha_resultado.GetComponent<Renderer>().material = material;
    }
     private void OnTriggerStay(Collider other){
        Debug.Log("Stay");
     }

     private void OnTriggerExit(Collider other){
        plancha_resultado.GetComponent<Renderer>().material = color_Original;
     }
}
