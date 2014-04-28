using UnityEngine;
using System.Collections;

public class Testing : MonoBehaviour {
    public AnimationClip clip;

	// Use this for initialization
	void Start () {
        animation.clip = clip;
        animation.Play();
	}
}
