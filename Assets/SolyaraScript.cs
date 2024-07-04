using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolyaraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PapechHealthMana>().ManaChange(50);
            Destroy(gameObject);
        }
    }
}
