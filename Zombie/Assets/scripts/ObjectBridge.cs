using UnityEngine;
using System.Collections;

public class ObjectBridge : MonoBehaviour {
	[SerializeField] float objectSpeed=20;
	[SerializeField] private float resetPosition=41.311f;
	[SerializeField] private float startPosition=-75.03876f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		if(!GameManager.instance.GameOver){
			transform.Translate(Vector3.left*(objectSpeed *Time.deltaTime));
			if(transform.localPosition.x>=resetPosition){
				Vector3 newPos=new Vector3(startPosition,transform.position.y,transform.position.z);
				transform.position=newPos;
			}
		}
	}
}
