using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    Animator EnemyControler;
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        EnemyControler = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("GAME OVER :( !");

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            //Debug.Log("AIIIIIIIE !!!");
            EnemyControler.SetTrigger("Dead");
        }
    }

}

