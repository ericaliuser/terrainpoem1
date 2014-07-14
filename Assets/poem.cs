using UnityEngine;
using System.Collections;

public class poem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ( "Poem Here" );
		
		GetComponent<TextMesh>().text = "Roald Dahl\n I had a little nut-tree\nNothing would it bear\nI searched in all its branches\nBut not a nut was there\nOh, little tree, I begged\n Give me just a few\n The little tree looked down at me\n and whispered, nuts to you";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
