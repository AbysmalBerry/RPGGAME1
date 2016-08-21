using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization
    private float speed = 3;
    private Rigidbody2D myRigidbody2D;
    private bool onGround = false;
    void Start () {
        myRigidbody2D = GetComponent<Rigidbody2D>();


    }
	
	// Update is called once per frame
	void Update () {
        Vector3 moveDir = Vector3.zero;
      
        moveDir.x = Input.GetAxis("Horizontal"); // get result of AD keys in X
        transform.position += moveDir * speed * Time.deltaTime;

        if (Input.GetKeyDown("space") && onGround == true)
        {
            Vector3 up = transform.TransformDirection(Vector3.up);
            myRigidbody2D.AddForce(up * 5, ForceMode2D.Impulse);
            onGround = false;
        }
       
    }

    //void OnCollisionEnter(Collision2D other)
    //{
    //    onGround = true;
    //}

    void OnCollisionStay2D (Collision2D other)
    {
        onGround = true;
    }
}
