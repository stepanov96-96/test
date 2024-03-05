using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private int health = 3; // начальное количество жизней монстра
    private int score = 0; // начальное количество очков

    public void OnClick()
    {
        if (health > 0) // проверяем, что у монстра остались жизни
        {
            health--; // уменьшаем количество жизней на 1

            if (health == 0) // если жизни закончились
            {
                score += 100; // увеличиваем количество очков на 100
                Debug.Log("Монстр уничтожен! Очки: " + score); // выводим сообщение о том, что монстр уничтожен и отображаем текущее количество очков
            }
        }
    }
}