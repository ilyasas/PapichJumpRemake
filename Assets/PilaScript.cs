using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilaScript : MonoBehaviour
{
    float time = 0;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player=GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        if (time>=3)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
}
