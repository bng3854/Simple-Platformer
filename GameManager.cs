using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;


public class GameManager : MonoBehaviour
{
    public int coinScore;
    public int playerChances = 3;
    public Text winText;
    public Text score;
    public Text chances;
    public Text loseText;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        winText.text = "";
        loseText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + coinScore.ToString();
        chances.text = "Chances: " + playerChances.ToString();

        if (coinScore >= 12)
        {
            SceneManager.LoadScene(1);
        }
        if (playerChances == 0)
        {

            loseText.text = "You lost!";
            Player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
