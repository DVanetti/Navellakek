using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
[SerializeField] List<GameObject> windows;
	public void PlayGame ( ) 
                  {
                         SceneManager.LoadScene(SceneManager.GetActiveScene( ) .buildIndex + 1); }

public void OpenWindowByName(string name)
{
foreach (GameObject g in windows)
{
g.SetActive(g.transform.name == name);
}
}
public void CloseWindowByName(string name)
{
foreach (GameObject g in windows)
{
if (g.transform.name == name) g.SetActive(false);
}
}
public void StartGameplay()
{
SceneManager.LoadScene("Go", LoadSceneMode.Single);
}
}


