using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceFrogAi : MonoBehaviour
{
    public AudioClip[] deathsound;
    public AudioClip smertpila;
    PapechHealthMana sas;
    public ParticleSystem blood;
    public GameObject pulya;
    public float period, power, shootperiod;
    Vector3 startpos;
    Vector3 vec;
    Vector3 pl;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
       sas = GameObject.FindGameObjectWithTag("Player").GetComponent<PapechHealthMana>();
       player =GameObject.FindGameObjectWithTag("Player").transform;
       startpos = transform.position;
       InvokeRepeating("Shoot", shootperiod, shootperiod);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = startpos + power*(new Vector3(0,Mathf.Sin(2 * Mathf.PI * (Time.time) / period)));
        pl = player.position - transform.position;
        vec[2]= Vector3.SignedAngle(new Vector3(1, 0, 0), pl, Vector3.forward);
        transform.eulerAngles = vec;
    }
    void Shoot()
    {
        Instantiate(pulya, transform.position, transform.rotation);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if (collision.tag.Contains("Killer"))
        {
            if (collision.CompareTag("KillerPila"))
            {
                AudioSource.PlayClipAtPoint(smertpila, GameObject.FindGameObjectWithTag("Listener").transform.position, 5000);
            }
            else
            {
                AudioSource.PlayClipAtPoint(deathsound[Random.Range(0,deathsound.Length)], GameObject.FindGameObjectWithTag("Listener").transform.position, 5000);
            }
            Instantiate(blood, transform.position, transform.rotation);
            AllScores.score += 23;
            sas.exp += 40;
            Destroy(gameObject);     
        }
    }
}
