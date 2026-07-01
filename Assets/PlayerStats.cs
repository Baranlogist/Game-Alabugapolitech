using UnityEngine;
using TMPro; // ВАЖНО: эта строчка позволяет коду работать с текстом TextMeshPro

public class PlayerStats : MonoBehaviour
{
    // Переменные для логики игры
    public int hp = 100;
    public int money = 50;

    // Ссылки на текстовые объекты на Канвасе
    public TextMeshProUGUI hpTextDisplay;
    public TextMeshProUGUI moneyTextDisplay;

    // Метод Update вызывается автоматически каждый кадр игры
    void Update()
    {
        // Выводим ХП на экран. Строка запишется как "HP: 100"
        hpTextDisplay.text = "HP: " + hp.ToString();

        // Выводим деньги на экран. Строка запишется как "Gold: 50"
        moneyTextDisplay.text = "$: " + money.ToString();
    }
}