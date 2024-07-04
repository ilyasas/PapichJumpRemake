using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAI : MonoBehaviour
{
    public AudioClip vzriw, pusk;
    public GameObject Explosion;
    Vector3 pl,vec;
    Collider2D[] objects;
    GameObject target;
    public float duration=3;
    public float speed = 1f, turnRate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = speed * (new Vector3(0, 1).normalized);
        target = GameObject.FindGameObjectWithTag("Player");
        AudioSource.PlayClipAtPoint(pusk, GameObject.FindGameObjectWithTag("Listener").transform.position, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Exploseon", duration);
        gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.RotateTowards(gameObject.GetComponent<Rigidbody2D>().velocity, target.transform.position - transform.position, turnRate, 0);
        pl = gameObject.GetComponent<Rigidbody2D>().velocity;
        vec[2] = Vector3.SignedAngle(new Vector3(1, 0, 0), pl, Vector3.forward);
        transform.eulerAngles = vec;
    }
    void Exploseon()
    {
        AudioSource.PlayClipAtPoint(vzriw, GameObject.FindGameObjectWithTag("Listener").transform.position, 0.02f);
        objects = Physics2D.OverlapCircleAll(transform.position, 1.5f);
        foreach (Collider2D currentEnemy in objects)
        {
            if (currentEnemy.CompareTag("Player"))
            {
                currentEnemy.GetComponent<PapechHealthMana>().Damage(30);
                ParticleSystem.Instantiate(Explosion, transform.position, transform.rotation);
                Destroy(gameObject);
                return;
            }
        }       
        ParticleSystem.Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(gameObject);   
    }
}
