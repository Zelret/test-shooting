using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    
    public float Movespeed;

    GameObject Player;
    Vector2 Player_size;
    Vector2 local_player_size;

    // Use this for initialization
    void Start () {

        //Player = GameObject.FindWithTag("Player");
        Player_size = GetComponent<SpriteRenderer>().sprite.rect.size;
        local_player_size = Player_size / GetComponent<SpriteRenderer>().sprite.pixelsPerUnit;
        Movespeed = 5f;
	
	}
	
	// Update is called once per frame
	void Update () {

        move();
        //transform.position.Set(Player_size.x, Player_size.y, 0);

    }

    void move()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true && transform.position.y < 10 - local_player_size.y)
        {
            transform.Translate(Vector2.up.normalized * Movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow) == true && transform.position.y > local_player_size.y)
        {
            transform.Translate(Vector2.down.normalized * Movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true && transform.position.x > local_player_size.x)
        {
            transform.Translate(Vector2.left.normalized * Movespeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true && transform.position.x < 7.5f - local_player_size.x)
        {
            transform.Translate(Vector2.right.normalized * Movespeed * Time.deltaTime);
        }
    }
}
