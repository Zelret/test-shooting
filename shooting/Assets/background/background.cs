using UnityEngine;
using System.Collections;

public class background : MonoBehaviour {

    public float ScrollSpeed;
    Material thismaterial;

    Vector2 Offset;

    // Use this for initialization
    void Start () {

        ScrollSpeed = 0.3f;
        thismaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {

        Offset = thismaterial.mainTextureOffset;
        Offset.Set(0, Offset.y + (ScrollSpeed * Time.deltaTime));
        thismaterial.mainTextureOffset = Offset;

	}
}