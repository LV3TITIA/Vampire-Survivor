using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Exposed

    [SerializeField]
    private Vector2 velocity;
   

    [SerializeField]
    private float speed;

    #endregion

    void Awake()
    {   
       
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical") * speed;
        horizontal = Input.GetAxis("Horizontal") * speed;
        
    }

    private void FixedUpdate()
    {
        Vector2 direction = new Vector2(horizontal, vertical);
        rb2D.velocity = direction.normalized * speed;

    }

    #region Private

    private float vertical;
    private float horizontal;

    private Rigidbody2D rb2D;

    #endregion
}
