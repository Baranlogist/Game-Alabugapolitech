using UnityEngine;
using System.Collections; // Это нужно для работы таймера

public class EnemySpawner : MonoBehaviour
{
    [Header("Настройки волны")]
    public GameObject enemyPrefab;   // Сюда мы положим твоего моба
    public int enemiesToSpawn = 10;  // СКОЛЬКО ВСЕГО мобов выйдет за уровень (твой предел!)
    public float timeBetweenSpawns = 2f; // Пауза в секундах между мобами

    void Start()
    {
        // При старте игры запускаем процесс выдачи мобов
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        // Цикл повторяется ровно столько раз, сколько ты указал в enemiesToSpawn
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            // Создаем копию моба ровно в той точке, где стоит Спавнер
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            
            // Ждем указанное время перед тем, как выпустить следующего
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
        
        Debug.Log("Все мобы вышли! Волна закончена.");
    }
}