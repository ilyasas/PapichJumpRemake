using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBeh : MonoBehaviour
{
    public GameObject vzriw;
    Rigidbody2D Player;
    public float Speed=1f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (Player.velocity.y<=0 && collision.CompareTag("Platform"))
        {
            transform.parent.GetComponentInChildren<Animator>().SetTrigger("Kort");
            Player.velocity = new Vector3(Player.velocity.x, Speed);
            Instantiate(vzriw, collision.transform.parent.transform.position, collision.transform.parent.transform.rotation);
            AllScores.score += 5;
            Destroy(collision.transform.parent.gameObject);
        }
    }
}
