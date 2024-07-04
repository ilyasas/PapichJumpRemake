using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClokAI : MonoBehaviour
{
    public AudioClip[] smertzvuk;
    public GameObject rocket;
    bool pustil = false;
    PapechHealthMana sas;
    public float damage=30;
    // Start is called before the first frame update
    void Start()
    {
        sas = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if (!pustil&&gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Clock"))
        {
            GetComponent<BoxCollider2D>().size = 2*GetComponent<BoxCollider2D>().size;
            Invoke("Rocket", 1);
            pustil = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PapechHealthMana>().Damage(damage);
            if(collision.GetComponent<Rigidbody2D>().velocity.y>0 && gameObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Clock"))
            {
                collision.GetComponent<Rigidbody2D>().velocity = new Vector2(collision.GetComponent<Rigidbody2D>().velocity.x, -3f);
            }
        }
        if (collision.CompareTag("KillerPila"))
        {
            AudioSource.PlayClipAtPoint(smertzvuk[Random.Range(0, smertzvuk.Length)], GameObject.FindGameObjectWithTag("Listener").transform.position);
            AllScores.score += 50;
            sas.exp += 40;
            Destroy(gameObject);
        }
    }
    void Rocket()
    {
        Instantiate(rocket,transform.position,transform.rotation);
    }
}
