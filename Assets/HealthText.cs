using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    float healthMax, health;
    // Start is called before the first frame update
    void Start()
    {
        healthMax = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().health;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        health = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().health;
        gameObject.GetComponent<Text>().text = $"{health}/{healthMax}";

    }
}
