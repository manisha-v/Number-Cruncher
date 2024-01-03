using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public AudioSource gameOversound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setup()
    {
        gameOversound.Play();
        
        ScoreText.text = "score: " + ScoreScript.score;
        gameObject.SetActive(true);

    }

    public void restart()
    {
        ScoreScript.score = 0;
        SceneManager.LoadScene("GameScene");
    }

    public void quit()
    {
        Application.Quit();
    }
}
