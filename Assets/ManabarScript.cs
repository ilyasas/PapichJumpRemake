using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManabarScript : MonoBehaviour
{
    Slider manabar;

    // Start is called before the first frame update
    void Start()
    {
        manabar = GetComponent<Slider>();
        manabar.maxValue = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().mana;
    }

    // Update is called once per frame
    void Update()
    {
        manabar.value = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().mana;
    }
}
