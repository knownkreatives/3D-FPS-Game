using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
   public PlayerHealth playerHealth;
   public Next next;
   public DeathUI dUI;

   public void CheckIfDead(){
     if(playerHealth.remainHealth == 0){
       dUI.ToggleTime();
     }
     return;
   }

   public void IsDead(){
     next.next(next.levelString);
   }
}
