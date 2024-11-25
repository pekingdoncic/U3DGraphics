using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class IK : MonoBehaviour {
    protected Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
    void OnAnimatorIK()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.up, transform.position);
        float enter = 0f;
        if(plane.Raycast(ray, out enter))
        {
            Vector3 target = ray.GetPoint(enter);
            anim.SetLookAtPosition(target);
            anim.SetLookAtWeight(1f, 0.5f, 0.8f, 0.9f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
