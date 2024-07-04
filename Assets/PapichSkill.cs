using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PapichSkill : MonoBehaviour
{
    public AudioClip[] skil1, skil2, skil3;
    PapechHealthMana sas;
    bool fly;
    Rigidbody2D rigidbodys;
    public GameObject pila;
    public GameObject stan;
    public float manacost1=25, manacost2 = 50, manacost3 = 50,flyduration=3;
    // Start is called before the first frame update
    void Start()
    {
        sas = GetComponent<PapechHealthMana>();
        rigidbodys = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            qskill();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            wskill();
        }
        if (Input.GetButtonDown("Fire3"))
        {
            eskill();
        }
    }
    public void qskill()
    {
        if (sas.mana >= manacost1)
        {
            Instantiate(stan, transform.position, transform.rotation);
            sas.ManaChange(-manacost1);
        }
    }

    public void wskill()
    {
        if (sas.mana >= manacost2 && sas.lvl >= 2)
        {
            AudioSource.PlayClipAtPoint(skil2[Random.Range(0, skil2.Length)], GameObject.FindGameObjectWithTag("Listener").transform.position, 200f);
            fly = true;
            StartCoroutine("DisableFly");
            sas.ManaChange(-manacost2);
        }
    }
    public void eskill()
    {
        if (sas.mana >= manacost3 && sas.lvl >= 3)
        {
            AudioSource.PlayClipAtPoint(skil3[Random.Range(0, skil3.Length)], GameObject.FindGameObjectWithTag("Listener").transform.position, 200f);
            Instantiate(pila, transform.position, transform.rotation);
            sas.ManaChange(-manacost3);
        }

    }



    private void FixedUpdate()
    {
        if (fly)
        {           
            rigidbodys.velocity = new Vector3(rigidbodys.velocity.x, 5f);
        }
    }
    IEnumerator DisableFly()
    {
        yield return new WaitForSeconds(flyduration);
        fly = false;
    }
}
