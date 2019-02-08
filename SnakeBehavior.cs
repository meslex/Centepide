using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBehavior : MonoBehaviour {

    public GameObject previousSegment;
    public GameObject nextSegment;
    public State state;
    public float speed;

    private Vector2 prevPosition;
    private int id;

    public Vector2 PreviousPosition{
        get{return prevPosition;}
    }


	// Use this for initialization
	void Start () {
		prevPosition = GetComponent<Rigidbody2D>().position;
	}
	
    public void SetId(int id){
        this.id = id;
    }

    public void Move(){
        GetComponent<Rigidbody2D>().position = nextSegment.GetComponent<SnakeBehavior>().PreviousPosition;
    }
	// Update is called once per frame
	void Update () {
        prevPosition = GetComponent<Rigidbody2D>().position;
		if(state != State.HEAD){
            
            
        }else{
            float moveHorizontal = Input.GetAxis("Horizontal") * speed;
            float moveVertical = Input.GetAxis("Vertical") * speed;
        
        
		//float moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(moveHorizontal, moveVertical) ;
            movement = Vector2.ClampMagnitude(movement, speed);
            GetComponent<Rigidbody2D>().position += movement;
        }

	}

}
