using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpText : MonoBehaviour
{
    PapechHealthMana sas;
    float maxExp, exp;
    // Start is called before the first frame update
    void Start()
    {
        sas = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>();
        maxExp = sas.maxExp;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        exp = sas.exp;
        gameObject.GetComponent<Text>().text = $"{exp}/{maxExp}";

    }
}
