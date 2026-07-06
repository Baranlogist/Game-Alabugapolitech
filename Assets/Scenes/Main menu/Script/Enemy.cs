using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f; // Скорость моба (сможешь менять прямо в Unity)

    private Transform[] waypoints;
    private int currentWaypointIndex = 0;

    void Start()
    {
        // ИИ моба: случайным образом выбирает число 1, 2 или 3
        int randomPath = Random.Range(1, 4); 
        
        // Находит на карте нужную папку-дорогу (Path1, Path2 или Path3)
        Transform pathObject = GameObject.Find("Path" + randomPath).transform;
        
        // Достает из этой папки все твои точки по порядку
        waypoints = new Transform[pathObject.childCount];
        for (int i = 0; i < pathObject.childCount; i++)
        {
            waypoints[i] = pathObject.GetChild(i);
        }
    }

    void Update()
    {
        // Если точки еще не закончились
        if (currentWaypointIndex < waypoints.Length)
        {
            // Плавно двигаемся к следующей точке
            transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);
            
            // Если подошли к точке почти вплотную - переключаемся на следующую
            if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
            {
                currentWaypointIndex++;
            }
        }
        else
        {
            // Моб дошел до последней точки (до твоей базы)
            Debug.Log("Моб дошел до базы! Скоро прикрутим урон.");
            Destroy(gameObject); // Уничтожаем моба, чтобы он не висел бесконечно на экране
        }
    }
    public void Die()
{
    Destroy(gameObject); // Эта команда просто удаляет объект моба со сцены
}
}