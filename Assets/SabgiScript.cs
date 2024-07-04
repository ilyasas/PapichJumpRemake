using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SabgiScript : MonoBehaviour
{
    public AudioClip zvuk;
    public float period=5, power=30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = power * (new Vector3(0, 0, Mathf.Sin(2 * Mathf.PI * (Time.time) / period)));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(zvuk, GameObject.FindGameObjectWithTag("Listener").transform.position, 0.1f);
            AllScores.sabgi+=100;
            Destroy(gameObject);
        }
    }
}
