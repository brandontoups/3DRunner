/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour {



    bool gameHasEnded = false;
    public float loadDelay = 2f;



    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Invoke("GameOverScene", loadDelay);
        }
    }

    public void GameOverScene() {
        SceneManager.LoadScene("GameOver");
    }

}
