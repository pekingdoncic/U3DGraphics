using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMatching : MonoBehaviour {
    private Animator animator;
    public Transform rightFoot;
    AnimatorStateInfo animState;
    public float matchStart, matchEnd;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(animator)
        {
            animState = animator.GetCurrentAnimatorStateInfo(0);
            if (Input.GetButton("Fire1")) animator.SetTrigger("Jump");
            if(animState.IsName("JumpUp"))
            {
                animator.MatchTarget(rightFoot.position, rightFoot.rotation,
                    AvatarTarget.RightFoot, new MatchTargetWeightMask(new Vector3(1, 1, 1), 1)
                    , matchStart, matchEnd);
            }
        }
	}
}
