using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public string levelString;

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
          try{
            next(levelString);
          }
          catch{
            next("Menu");
          }
        }
    }

    public void next(string nextLevel = "Menu"){
        SceneManager.LoadScene(nextLevel);
    }
}
