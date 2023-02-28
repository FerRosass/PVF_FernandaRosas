using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Detected : MonoBehaviour
{
    public Logic_Script logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_Script>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.gameObject.layer == 3)
        {
            if (gameObject.tag == "Fruit")
            {
                logic.addScore(1);
                Destroy(gameObject);
            }
            else if (gameObject.tag=="Bomb")
            {
                logic.gameOver();
                Destroy(gameObject);
                Destroy(Player.gameObject);
            }
        }

    }
}