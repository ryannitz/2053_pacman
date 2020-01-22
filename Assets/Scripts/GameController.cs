using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public Text timerText;
    public Text mainScreenText;

    public GameObject ghost;

    private int secondsTime = 0;
    private float totalTime;

    private bool gameOver = false;

    private string STR_LOSE = "You Lose";
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateGhost", 5f, 5f);
        mainScreenText.text = "";
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            UpdateGameTimer();
        }
    }

    void UpdateGameTimer()
    {
        totalTime += Time.deltaTime;
        secondsTime = (int)totalTime;
      
        //Debug.Log(remainingSeconds.ToString());
        timerText.text = "Time: " + secondsTime.ToString() + "s";
        
    }

    public void GameOver()
    {
        gameOver = true;
        mainScreenText.text = STR_LOSE;
        
    }

    void CreateGhost()
    {
        Instantiate(ghost, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }
}
