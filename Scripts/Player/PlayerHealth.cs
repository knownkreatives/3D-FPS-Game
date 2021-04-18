using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  public float health;
  [Header("DONT TAMPER.")]
  public float initHealth;
  public float remainHealth;

  void Start(){
    initHealth = health;
    remainHealth = health;
  }

  public void TakeDamage(float value){
    remainHealth -= value;
  }
}
