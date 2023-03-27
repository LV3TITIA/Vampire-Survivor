using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _enemyPrefab;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private Rigidbody2D _RgbD2;

    private void Awake()
    {
        CapsuleTransform = GameObject.Find("Capsule").GetComponent<Transform>();
        _enemyPrefab.gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        //transform.LookAt(CapsuleTransform);
        //_RgbD2.velocity = 
        //Vector2 MoveToPlayer = (transform.position, CapsuleTransform.position);
        //transform.position = Vector2.MoveTowards(transform.position, CapsuleTransform.position, _speed);

        Vector2 _direction = new Vector2(); //
        _direction = CapsuleTransform.position - transform.position;// Direction enemi - joueur 
        Debug.DrawRay(transform.position, _direction * 10, Color.red);
        _direction = _direction.normalized;
        _RgbD2.velocity = _direction * _speed;


        //_directionToPlayer = (CapsuleTransform.position - transform.position);
    }

    private Transform CapsuleTransform;

    //private Vector2 _directionToPlayer;
    //private Vector2 MoveToPlayer;
}
