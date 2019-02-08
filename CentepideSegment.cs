using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentepideSegment : MonoBehaviour {

    public GameObject previousSegment;
    public GameObject nextSegment;
    public GameObject tail;
    public State state;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BecomeTail(){

    }

    public void BecomeHead(){

    }

    public void Reorder(GameObject tail, bool whichWay){

    }

    private void Swap(){
        GameObject temp = previousSegment;
        previousSegment = nextSegment;
        nextSegment = temp;
    }
}

public enum State{
    HEAD,
    TAIL,
    IN_BETWEEN
}
