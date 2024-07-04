using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing : MonoBehaviour
{
    float flashtime;
    SpriteRenderer sprite;
    PapechHealthMana invinc;
    // Start is called before the first frame update
    void Start()
    {
       invinc=GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>();
       sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (invinc.inv)
        {
            flashtime += Time.fixedDeltaTime;
            if (flashtime >= 0.1f)
            {
                sprite.enabled = !sprite.enabled;
                flashtime = 0;
            }
        }
    }

}
