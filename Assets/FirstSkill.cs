using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSkill : MonoBehaviour
{
    PapechHealthMana sas;
    // Start is called before the first frame update
    void Start()
    {
        sas = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(sas.lvl>=2)
        {
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
