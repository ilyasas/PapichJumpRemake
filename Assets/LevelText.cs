using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelText : MonoBehaviour
{
    PapechHealthMana sas;
    // Start is called before the first frame update
    void Start()
    {
        sas= GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = $"{sas.lvl}";
    }
}
