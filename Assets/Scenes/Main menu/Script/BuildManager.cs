using UnityEngine;

public class BuildManager : MonoBehaviour
{
    // Делаем менеджер доступным из любого скрипта (Синглтон)
    public static BuildManager instance;

    // Сюда будет сохраняться префаб выбранной башни
    private GameObject towerToBuild; 

    void Awake()
    {
        if (instance != null) return;
        instance = this;
    }

    // Этот метод мы повесим на кнопки в UI инвентаре
    public void SelectTowerToBuild(GameObject towerPrefab)
    {
        towerToBuild = towerPrefab;
        Debug.Log("Выбрана башня: " + towerPrefab.name);
    }

    public GameObject GetTowerToBuild()
    {
        return towerToBuild;
    }
}