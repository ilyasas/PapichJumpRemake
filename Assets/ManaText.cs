using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaText : MonoBehaviour
{
    float manaMax, mana;
    // Start is called before the first frame update
    void Start()
    {
        manaMax = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().mana;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mana = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>().mana;
        gameObject.GetComponent<Text>().text = $"{mana}/{manaMax}";

    }
}
