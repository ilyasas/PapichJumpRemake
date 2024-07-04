using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBeh : MonoBehaviour
{
    float time, trans;
    public float fadeTime;
    Color col;
    SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        col = rend.color;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        trans = 1 - time / fadeTime;
        col[3] = trans;
        rend.color = col;
        if (time >= fadeTime)
        {
            Destroy(gameObject);
        }
    }
}
