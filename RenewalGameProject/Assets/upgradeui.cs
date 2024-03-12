using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class upgradeui : MonoBehaviour
{
    [SerializeField] GameObject upgrademenu;
    //
    //pause menu
    //

    //public void home()
    //{
    //    SceneManager.LoadScene("Main Menu");
    //}
    public void pause()
    {
        upgrademenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void upgrade1()
    {
        upgrademenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void upgrade2()
    {
        upgrademenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void restartrun()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
