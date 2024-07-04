using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpBarScript : MonoBehaviour
{
    Slider expbar;
    PapechHealthMana sas;
    float oldlevel;
    // Start is called before the first frame update
    void Start()
    {
        sas= GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>();
        expbar = GetComponent<Slider>();
        expbar.maxValue = sas.maxExp;
        oldlevel = sas.lvl;
    }

    // Update is called once per frame
    void Update()
    {
        expbar.value = sas.exp;
        if(oldlevel!=sas.lvl)
        {
            oldlevel = sas.lvl;
            expbar.maxValue = sas.maxExp * oldlevel;
        }
    }
}
