using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject MenuUi, GameUi, StartUi, StartUiText, Camera, Game, Fire, WinUi, LoseUi;
    void Update()
    {
        
    }
    public void StartButton()
    {
        MenuUi.gameObject.SetActive(false);
        Camera.gameObject.GetComponent<Animator>().Play("cameranim");
    }
    public void Startday()
    {
        StartUiText.GetComponent<Text>().text = "Night 1";
        StartUi.gameObject.SetActive(true);
    }
    public void StartLvl()
    {
        StartUi.gameObject.SetActive(false);
        GameUi.SetActive(true);
        Game.SetActive(true);
    }
    public void GameOver()
    {
        Game.SetActive(false);
        GameUi.SetActive(false);
        Fire.SetActive(false);
        Camera.gameObject.GetComponent<Animator>().Play("cameranim2");
    }
    public void StartMenu()
    {
        MenuUi.gameObject.SetActive(true);
        WinUi.SetActive(false);
        LoseUi.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void Win()
    {
        Game.SetActive(false);
        GameUi.SetActive(false);
        Camera.gameObject.GetComponent<Animator>().Play("cameranim2");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
