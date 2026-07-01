using UnityEngine;
using UnityEngine.SceneManagement; // Обязательно добавляем для работы со сценами

public class MainMenu : MonoBehaviour
{
    // Метод для кнопки "Играть"
    public void PlayGame()
    {
        // Загружает следующую сцену в настройках билда (например, первый уровень)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Метод для кнопки "Выход"
    public void QuitGame()
    {
        // Это сообщение появится только в редакторе Unity, чтобы ты видел, что кнопка работает
        Debug.Log("Игрок вышел из игры!"); 
        
        // Закрывает скомпилированную игру
        Application.Quit(); 
    }
}
