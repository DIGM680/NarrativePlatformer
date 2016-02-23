using UnityEngine;
using System.Collections;

public class openingFade : MonoBehaviour {
	private SpriteRenderer screen;
	public float fadeSpeed = 1.2f;
	private float alpha = 1.0f;
	private bool fade = false;
	private Color step;
	// Use this for initialization
	void Start () {
		screen = this.GetComponent<SpriteRenderer> ();
		step = screen.color;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space))
			fade = true;
		if (screen.color.a <= 0)
			Destroy (this.gameObject);
		if (fade) {
			alpha += -1f * fadeSpeed * Time.deltaTime;
			alpha = Mathf.Clamp01 (alpha);
			if (alpha < 0)
				alpha = 0f;
			step = new Color (step.r, step.g, step.b, alpha);
			screen.color = step;
		}
	}
}
