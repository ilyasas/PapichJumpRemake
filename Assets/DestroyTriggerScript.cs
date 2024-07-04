using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
        if (!collision.CompareTag("Player"))
        {
            foreach (Transform child in collision.transform)
            {
                GameObject.Destroy(child.gameObject);
            }
            Destroy(collision.gameObject);
        }
    }
}
