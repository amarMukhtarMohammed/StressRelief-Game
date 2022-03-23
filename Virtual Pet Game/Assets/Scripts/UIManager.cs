using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{


    [SerializeField] GameObject LevelCompleteUI = null;
    [SerializeField] GameObject pauseUI = null;
    // Start is called before the first frame update
    void Start()
    {
        Global.isPaused = false;
    }
        



    public void levelComplete()
    {
        LevelCompleteUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Global.movable = false;
    }

    public void togglePauseMenu()
    {
        Global.isPaused = !Global.isPaused;
        if (Global.isPaused)
        {
            //open pause menu 
            Time.timeScale = 0;
            pauseUI.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            //close pause menu
            Time.timeScale = 1;

            pauseUI.SetActive(false);

        }
    }


    public void quit()
    {
        Application.Quit();
    }
}
