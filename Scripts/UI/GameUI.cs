using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    private Player p;

    public GameObject player;
    public GameObject death;
    public GameObject pause;

    private Canvas deathUI;
    private Canvas pauseUI;

    void Start(){
      deathUI = death.GetComponent<Canvas>();
      pauseUI = pause.GetComponent<Canvas>();
    }
}
