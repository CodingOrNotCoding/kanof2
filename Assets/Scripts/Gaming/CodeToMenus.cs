using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CodeToMenus : MonoBehaviour
{


	void Start()
	{
		
	}

	public void rest()
	{
		Time.timeScale = 1;		SceneManager.LoadScene("MainGameScene 1");
	}
    public void stopped()
    {

		Time.timeScale = 0;
		SceneManager.LoadScene("stopGameScene", LoadSceneMode.Additive);
	}
	public void resume()
	{
		
		SceneManager.UnloadScene("stopGameScene");
		Time.timeScale = 1;
	}
	public void store()
	{
		SceneManager.LoadScene("storeScene", LoadSceneMode.Additive);
	}
	public void backToStop()
	{
		SceneManager.UnloadScene("storeScene");
	}
}
