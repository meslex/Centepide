using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    [SerializeField] private SnakeBehavior CentepideSegment;

	// Use this for initialization
	void Start () {
		CreateCentepide();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void CreateCentepide(){
        SnakeBehavior previous;
        SnakeBehavior current;
        for(int i = 0; i < 20; ++i){
            current = Instantiate(CentepideSegment, new Vector3(0.15f * i, 0f, 0f), Quaternion.identity);
            previous = current;
            if(i == 0){
                current.state = State.HEAD;    
            }
            else if(i == 19){
                current.state = State.TAIL;
                current.nextSegment = previous;
            }
            else{
                current.state = State.IN_BETWEEN;
                current.nextSegment = previous;
            }

        }
    }
}
