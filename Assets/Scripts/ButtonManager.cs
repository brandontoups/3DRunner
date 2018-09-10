/*
 * Names: Jackson Pettus, Brandon Toups, Evan Kiser, Sam Wilson
 * Group: Taco Tuesdays
 * Date: 17 April 2018
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void startBtn(string RunnerScene) {
        SceneManager.LoadScene(RunnerScene);
    }

    public void mainMenuBtn(string MainMenu) {
        SceneManager.LoadScene(MainMenu);
    }
}
