using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindClosest : MonoBehaviour {
	GameObject target;
	float time;
	Collider2D closestEnemy;
	Collider2D[] enemies;
	public float speed = 1f,turnRate=0.5f,duration=4f;
    // Update is called once per frame
    void Start()
    {
		gameObject.GetComponent<Rigidbody2D>().velocity = speed*(new Vector3(0, 1).normalized);
	}
    void FixedUpdate () 
	{
		time += Time.deltaTime;
		if (time >= duration)
		{
			Destroy(gameObject);
		}
		target=FindClosestEnemy();
		if (target != null)
		{
			gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.RotateTowards(gameObject.GetComponent<Rigidbody2D>().velocity,target.transform.position-transform.position,turnRate,0);
		}
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {			
			Destroy(gameObject);

		}
    }

    GameObject FindClosestEnemy()
	{
		float distanceToClosestEnemy = Mathf.Infinity;
		enemies = Physics2D.OverlapCircleAll(transform.position,10f);
		foreach (Collider2D currentEnemy in enemies) 
		{
			if (currentEnemy.CompareTag("Enemy"))
			{
				float distanceToEnemy = (currentEnemy.transform.position - this.transform.position).sqrMagnitude;
				if (distanceToEnemy < distanceToClosestEnemy)
				{
					distanceToClosestEnemy = distanceToEnemy;
					closestEnemy = currentEnemy;
				}
			}
		}
		if (closestEnemy != null)
		{
			return closestEnemy.gameObject;
		}
        else
        {
			return null;
        }
	}

}
