using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamebuttons : MonoBehaviour
{

    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    public void goStore()
    {
        SceneManager.LoadScene(2);

    }

    public void backtostp()
    {
        SceneManager.LoadScene(3);

    }

    public void exitbtn()
    {
        SceneManager.LoadScene(0);

    }

}
