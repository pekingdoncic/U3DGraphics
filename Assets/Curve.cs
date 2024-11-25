using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curve : MonoBehaviour {
    public Transform bubble;
    private Vector3 originalScale;
	// Use this for initialization
	void Start () {
      //  bubble = transform.Find("Root/Ribs/Neck/Head/Bubble");
        originalScale = bubble.localScale;
	}
	
	// Update is called once per frame
	void Update () {
        float curve = GetComponent<Animator>().GetFloat("CurveValue");
        bubble.localScale = new Vector3(originalScale.x + curve, originalScale.y + curve, originalScale.z + curve);
	}
}
