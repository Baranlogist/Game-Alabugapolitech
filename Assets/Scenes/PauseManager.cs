using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pauseMenuPanel; // Панель меню паузы
    public GameObject pauseButton;     // Сама кнопка "Пауза" на экране

    // Метод для кнопки "Пауза" на экране
    public void PauseGame()
    {
        pauseMenuPanel.SetActive(true); // Показываем меню паузы
        pauseButton.SetActive(false);    // Прячем кнопку "Пауза", чтобы она не мешалась
        Time.timeScale = 0f;            // Останавливаем время
    }

    // Метод для кнопки "Продолжить" в меню паузы
    public void ResumeGame()
    {
        pauseMenuPanel.SetActive(false); // Прячем меню паузы
        pauseButton.SetActive(true);     // Возвращаем кнопку "Пауза" на экран
        Time.timeScale = 1f;             // Запускаем время обратно
    }

    // Метод для кнопки "В главное меню"
    public void GoToMainMenu()
    {
        Time.timeScale = 1f; // Обязательно возвращаем время в норму!
        SceneManager.LoadScene(0); // Загружаем главное меню
    }
}
