using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthbarScript : MonoBehaviour
{
    Slider healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Slider>();
        healthbar.maxValue = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().health;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().health;
    }
}
