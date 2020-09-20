using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles launching the game from a splash screen.
/// </summary>
public class BlackJackLauncher : MonoBehaviour
{
    [SerializeField]
    private float m_loadDelayTime = 1f;

    private bool m_gameLoading = false;

    protected void Update()
    {
        if (!m_gameLoading)
        {
            m_loadDelayTime -= Time.deltaTime;
            if (m_loadDelayTime <= 0)
            {
                LoadGame();
            }
        }
    }

    /// <summary>
    /// Load all the game content, and initialize key classes here.
    /// if there were a lot of things to load, put up a loading bar, and load asyncronously.
    /// </summary>
    private void LoadGame()
    {
        m_gameLoading = true;

        LoadContent();

        GoToMainMenu();
    }

    private void LoadContent()
    {
        BlackJackGame.Get().LoadContent();
    }

    private void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
