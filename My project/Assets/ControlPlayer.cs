using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class ControlPlayer : MonoBehaviour{

public float moveSpeed; 
public float jumpHeight;

public KeyCode Spacebar; 


public KeyCode L;
public KeyCode R;

    public Transform groundcheck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(Spacebar)&& grounded){
            Jump();
        }

        if (Input.GetKey(L)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if(GetComponent<SpriteRenderer>()!=null){
            GetComponent<SpriteRenderer>().flipX=true;
        }
        }
        if (Input.GetKey(R)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        if(GetComponent<SpriteRenderer>()!=null){
            GetComponent<SpriteRenderer>().flipX=false;
        }
        }

    }

    void Jump(){
        GetComponent<Rigidbody2D>().velocity=new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
}
 public Transform groundcheck;
 public float groundCheckRadius;
 public LayerMask whatIsGround;
 private bool grounded;
 
 void FixedUpdate(){
    grounded = Physics2D.OverlapCircle(groundcheck.position, groundCheckRadius,whatIsGround);
 }
 
 }