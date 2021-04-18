using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthManager : MonoBehaviour
{
    public Gradient g;
    public PlayerHealth pHealth;
    public Image fill;
    [Space]
    public Slider healthSlider;
    public TextMeshProUGUI text;

    private string damageTag = "Death";

    void FixedUpdate(){
      text.text = pHealth.remainHealth.ToString() + "/" + pHealth.initHealth.ToString();
      healthSlider.value = pHealth.remainHealth;

      fill.color = g.Evaluate(pHealth.remainHealth/pHealth.initHealth);
    }

    void OnTriggerEnter(Collider other){
      if(other.gameObject.tag == damageTag){
        pHealth.TakeDamage(pHealth.remainHealth);
      }
    }
}
