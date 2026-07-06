using UnityEngine;

public class Tower : MonoBehaviour
{
    public float range = 3f;      // Радиус стрельбы
    public float fireRate = 1f;   // Как часто стреляет
    private float nextFireTime;

    public GameObject bulletPrefab; // Сюда закинешь префаб желтого шарика

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            FindAndShoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void FindAndShoot()
    {
        // Ищем всех врагов на сцене
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            if (Vector2.Distance(transform.position, enemy.transform.position) <= range)
            {
                // Стреляем в первого попавшегося
                GameObject b = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                b.GetComponent<Bullet>().target = enemy.transform;
                break;
            }
        }
    }
}