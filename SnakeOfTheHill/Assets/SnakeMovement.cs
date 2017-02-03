using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour {

    public List<GameObject> Snake  =  new List<GameObject>();
    int Tictime;
    public int TicTimeLimit;
    public string dir = "w";
    public Vector3 pos;

    public string w = "w";
    public string a = "a";
    public string s = "s";
    public string d = "d";

    void Inputs()
    {
        if (Input.GetKeyDown(w))
        {
            dir = "w";
            Tictime = TicTimeLimit;
        }
        if (Input.GetKeyDown(s))
        {
            dir = "s";
            Tictime = TicTimeLimit;
        }

        if (Input.GetKeyDown(a))
        {
            dir = "a";
            Tictime = TicTimeLimit;
        }

        if (Input.GetKeyDown(d))
        {
            dir = "d";
            Tictime = TicTimeLimit;

        }
    }

    void addtosnake() {
        GameObject part = Instantiate(Resources.Load<GameObject>("part"))as GameObject;
        if (!Snake.Contains(part)) {
            Snake.Add(part);
        }
    }

    void Updatesnake() {
        Tictime++;



        if (Tictime >= TicTimeLimit) {

			for(int i = Snake.Count -1; i > 0 ; i--) {
				if (i > 0) {
					Snake[i].transform.position = Snake[i - 1].transform.position;
				}
			}
			Snake[0].transform.position = transform.position;

            switch (dir) {
                case "w":
                    pos.z++;
                    break;

                case "a":
                    pos.x--;
                    break;

                case "s":
                    pos.z--;
                    break;

                case "d":
                    pos.x++;
                    break;
            }

            transform.position = pos;

            Tictime = 0;
        }
    }

                // Use this for initialization
    void Start () {
        for (int i = 0; i<10 ; i++) {
            addtosnake();
        }
	}
	
	// Update is called once per frame
	void Update () {
        Inputs();
        Updatesnake();
	}
}
