using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathUI : MonoBehaviour
{
    public Death death;
    public Next next;
    private bool pause = false;

    void Start(){
        gameObject.SetActive(false);
    }

    public void ToggleTime(){
        pause = !pause;

        if(pause)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    public void Retry(){
      death.IsDead();
    }

    public void Menu(){
      next.next();
    }
}
