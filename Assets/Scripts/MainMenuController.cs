using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private NewGamePopupController m_newGamePopupController = null;

    [SerializeField]
    private Button m_newGameButton = null;

    [SerializeField]
    private Button m_playNewGameButton = null;

    protected void Start()
    {
        m_newGameButton.onClick.AddListener(NewGameButtonPressed);
        m_playNewGameButton.onClick.AddListener(PlayNewGameButtonPressed);
    }

    protected void OnDestroy()
    {
        m_newGameButton.onClick.RemoveListener(NewGameButtonPressed);
        m_playNewGameButton.onClick.RemoveListener(PlayNewGameButtonPressed);
    }

    private void NewGameButtonPressed()
    {
        m_newGamePopupController.gameObject.SetActive(true);
    }

    private void PlayNewGameButtonPressed()
    {
        SceneManager.LoadScene("Game");
    }

}
