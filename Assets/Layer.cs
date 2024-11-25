using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour {
    public float speed = 1f;
    private Animator anim = null;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0))
        {
            float w = anim.GetLayerWeight(1) > 1 ? 1 : anim.GetLayerWeight(1) + speed * Time.deltaTime;
            anim.SetLayerWeight(1, w);
        }
        else
        {
            float w = anim.GetLayerWeight(1) < 0 ? 0 : anim.GetLayerWeight(1) - speed * Time.deltaTime;
            anim.SetLayerWeight(1, w);
        }
	}
}
