using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    private float restartDelay = 1f;
    public GameObject completeLevelUI;

    public Transform player;

    public Vector3 startPosition = new Vector3(0, 1.5f, 0);

    public Text scoreText;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);


        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // player.position = startPosition;
        // scoreText.text = "0";
        // GetComponent<PlayerMovement>().enabled = true;
        // gameHasEnded = false;


    }

}
