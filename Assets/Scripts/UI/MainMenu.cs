using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        //will load the scene called Level1
        SceneManager.LoadScene("Level1");
    }

    public void OnQuitButtonClicked()
    {
        //this will only work in the build of the game
        Application.Quit();
    }
}
