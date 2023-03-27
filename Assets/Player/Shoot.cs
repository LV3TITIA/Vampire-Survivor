using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shoot : StateMachineBehaviour
{
    [SerializeField]
    GameObject _bulletPrefab;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _FireRate;

    private void Awake()
    {
        _bulletPrefab.gameObject.GetComponent<Rigidbody2D>();

        CapsuleTransorm = GameObject.Find("Capsule").GetComponent<Transform>();

    } 
    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateinfo, int layerindex)
    { 
       
            GameObject B1 = Instantiate(_bulletPrefab, CapsuleTransorm);
            GameObject B2 = Instantiate(_bulletPrefab, CapsuleTransorm);
            GameObject B3 = Instantiate(_bulletPrefab, CapsuleTransorm);
            GameObject B4 = Instantiate(_bulletPrefab, CapsuleTransorm);
            //Instantiate(_bulletPrefab, Vector3.left, Quaternion.identity);

            B1.GetComponent<Rigidbody2D>().velocity = Vector2.right *_speed;
            B2.GetComponent<Rigidbody2D>().velocity = Vector2.left *_speed;
            B3.GetComponent<Rigidbody2D>().velocity = Vector2.up * _speed;
            B4.GetComponent<Rigidbody2D>().velocity = Vector2.down * _speed;
            //_bullet.velocity = (Vector3.left * _speed);

    }



    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}

    private Transform CapsuleTransorm;

    private float _nextTimeToShoot;
}
