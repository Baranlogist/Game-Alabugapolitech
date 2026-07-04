using UnityEngine;
using UnityEngine.SceneManagement; // Нужно для переключения уровней

public class NavigationManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelectMenu;

    // Вызывается кнопкой "Играть"
    public void GoToLevelSelect() {
        mainMenu.SetActive(false);
        levelSelectMenu.SetActive(true);
    }

    // Вызывается кнопкой "Назад"
    public void GoToMainMenu() {
        levelSelectMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    // Вызывается кнопкой "Выход"
    public void QuitGame() {
        Application.Quit();
    }

    // Вызывается кнопками уровней
    public void LoadLevel(int levelIndex) {
        SceneManager.LoadScene(levelIndex);
    }
}