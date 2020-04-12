using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
	public int speed=20;

	public Rigidbody2D sesuatu;

	public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        
        sesuatu.velocity = new Vector2(1,-1) * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (sesuatu.velocity.x > 0){ // bergerak ke kanan 
        	sesuatu.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }else{
        	sesuatu.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);

        
    }
}
