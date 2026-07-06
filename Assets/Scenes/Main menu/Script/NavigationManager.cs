using UnityEngine;

public class InventoryToggle : MonoBehaviour
{
    [Header("Перетащи сюда панель инвентаря")]
    public GameObject inventoryPanel; 

    void Start()
    {
        // При старте игры сразу прячем инвентарь
        if (inventoryPanel != null)
        {
            inventoryPanel.SetActive(false);
        }
    }

    void Update()
    {
        // Если игрок нажал кнопку Tab на клавиатуре
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleState();
        }
    }

    // Эту функцию мы сможем вызывать и с экранной кнопки
    public void ToggleState()
    {
        if (inventoryPanel != null)
        {
            // Проверяем: если включен - выключаем, если выключен - включаем
            bool isActive = inventoryPanel.activeSelf;
            inventoryPanel.SetActive(!isActive);
        }
    }
}