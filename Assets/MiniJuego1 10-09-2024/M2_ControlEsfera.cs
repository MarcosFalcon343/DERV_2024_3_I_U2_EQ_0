using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class M2_ControlEsfera : MonoBehaviour
{
    [SerializeField] List<GameObject> spawns;

    int index;

    private void OnCollisionEnter(Collision other){
        index = Random.Range(0, spawns.Count);
        transform.position = spawns[index].transform.position;
    }
}
