using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulyaAi : MonoBehaviour
{
    float trans=1,time=0;
    SpriteRenderer rend;
    Color col;
    public float speed, fadeTime, damage=25f;
    // Start is called before the first frame update
    void Start()
    {
        rend=gameObject.GetComponent<SpriteRenderer>();
        col = rend.color;
        trans = rend.color.a;
        gameObject.GetComponent<Rigidbody2D>().velocity = speed*(GameObject.FindGameObjectWithTag("Player").transform.position-transform.position).normalized;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        trans = 1 - time / fadeTime;
        col[3] = trans;
        rend.color = col;
        if(time>=fadeTime)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Killer"))
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PapechHealthMana>().Damage(damage);
            Destroy(gameObject);
        }
    }
}
