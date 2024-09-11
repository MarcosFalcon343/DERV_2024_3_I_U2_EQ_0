using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    int puntuacion = 0;
    [SerializeField] TextMeshProUGUI score;
    void Update()
    {
        int index_scene_active = SceneManager.GetActiveScene().buildIndex;
        if(index_scene_active == 0){// Inicio
            if(Input.GetKeyDown(KeyCode.Space)){
                SceneManager.LoadScene(1); // Escena de juego
            }
        }else if(index_scene_active == 1){ // Juego

        }else{ //Escena Final
            score.text = PlayerPrefs.GetInt("Puntaje",0).ToString();
        }
    }

    public void cambioEscena(int  index){
         SceneManager.LoadScene(index);
    }

    public void cambioEscena(int index, int puntuacion){
        PlayerPrefs.SetInt("Puntaje",puntuacion);
        cambioEscena(index);
    }
}
