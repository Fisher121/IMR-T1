using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerFound : MonoBehaviour
{
	private GameObject player1;
	private GameObject player2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player1 = GameObject.Find("Player1");
	float p1x =	player1.GetComponent<Transform>().position.x;
	float p1y = player1.GetComponent<Transform>().position.y;
	player2 = GameObject.Find("Player2");
	float p2x =	player2.GetComponent<Transform>().position.x;
	float p2y = player2.GetComponent<Transform>().position.y;

	float sq = Mathf.Sqrt((p1x - p2x) * (p1x - p2x) + (p1y - p2y) * (p1y - p2y));
	Debug.Log(sq);
	if (sq < 0.2){
			
			player1.GetComponent<Animator>().SetBool("other_char",true);
			player2.GetComponent<Animator>().SetBool("other_char",true);
		}	
	else{
			player1.GetComponent<Animator>().SetBool("other_char",false);
			player2.GetComponent<Animator>().SetBool("other_char",false);
	}
    }
}
