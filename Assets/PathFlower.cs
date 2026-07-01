using UnityEngine;

public class PathFlower : MonoBehaviour
{
    public Transform[] waypoints; // Массив точек нашей дорожки
    public float speed = 5.0f;    // Скорость движения объекта
    private int currentPointIndex = 0; // Индекс текущей точки

    void Update()
    {
        // Проверяем, не дошел ли объект до конца дорожки
        if (currentPointIndex < waypoints.Length)
        {
            // Перемещаем объект к текущей точке
            transform.position = Vector3.MoveTowards(
                transform.position, 
                waypoints[currentPointIndex].position, 
                speed * Time.deltaTime
            );

            // Если объект вплотную подошел к точке, переключаемся на следующую
            if (transform.position == waypoints[currentPointIndex].position)
            {
                currentPointIndex++;
            }
        }
    }
}