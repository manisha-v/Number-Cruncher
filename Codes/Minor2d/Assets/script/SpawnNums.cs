using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnNums : MonoBehaviour
{
    public GameOverScript gameover;
    //public NumBehaviour numBehav;
    GameObject g;
    // Groups
    public GameObject[] groups;
    int n, i;
    Vector3 border = new Vector3(0, -50, 0);

    public AudioSource movesound; 
    

    // Start is called before the first frame update
    void Start()
    {
        NumBehaviour.GameOver = false;
        ScoreScript.score = 0;
        spawnNext();
    }

    // Update is called once per frame
    void Update()
    {
        n = GetNumPressed();
        if(n>-1)
        Debug.Log("Got Num " + n);
        if (n == i)
        {
            movesound.Play();
            ScoreScript.score++;
            funct();
            Debug.Log("Destroyed num");
            spawnNext();
            Debug.Log("New num created");
        }
        if ((g.transform.position.y < border.y ) && (NumBehaviour.GameOver == false))
        {
            NumBehaviour.GameOver = true;          
            gameover.setup();
        }

            
            
    }
    public void funct()
    {
        Destroy(g.gameObject);
    }

    public void spawnNext()
    {
       
        // Random Index
        i = Random.Range(0, groups.Length);

        // Spawn Group at current Position
        g = (GameObject)Instantiate(groups[i], new Vector3(0, 30, 0), Quaternion.identity);
    }

    public int GetNumPressed()
    {
        if (Input.GetKeyDown(KeyCode.Keypad0))
            return 0;
        else if (Input.GetKeyDown(KeyCode.Keypad1))
            return 1;
        else if (Input.GetKeyDown(KeyCode.Keypad2))
            return 2;
        else if (Input.GetKeyDown(KeyCode.Keypad3))
            return 3;
        else if (Input.GetKeyDown(KeyCode.Keypad4))
            return 4;
        else if (Input.GetKeyDown(KeyCode.Keypad5))
            return 5;
        else if (Input.GetKeyDown(KeyCode.Keypad6))
            return 6;
        else if (Input.GetKeyDown(KeyCode.Keypad7))
            return 7;
        else if (Input.GetKeyDown(KeyCode.Keypad8))
            return 8;
        else if (Input.GetKeyDown(KeyCode.Keypad9))
            return 9;
        else
            return -1;
    }
}
