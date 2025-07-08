using UnityEngine;

public class Enums : MonoBehaviour
{
    private enum GameState
    {
        MainMenu,   // Главное меню
        Playing,    // Игра в процессе
        Paused,     // Игра на паузе
        GameOver    // Игра окончена
    }

    private GameState GetGameState()
    {
        if (IsMainMenu())
        {
            return GameState.MainMenu;
        }
        if (IsGameOver())
        {
            return GameState.GameOver;
        }
        if (IsPlaying())
        {
            return GameState.Playing;
        }
        if (IsGamePaused())
        {
            return GameState.Paused;
        }
        return GameState.MainMenu; // По умолчанию возвращаем главное меню, если ничего не подошло
    }

    private bool IsMainMenu()
    {
        // Здесь должна быть логика проверки, находимся ли мы в главном меню
        return false; // Заглушка
    }

    private bool IsGameOver()
    {
        // Здесь должна быть логика проверки, окончена ли игра
        return false; // Заглушка
    }
    private bool IsPlaying()
    {
        // Здесь должна быть логика проверки, идет ли игра
        return !IsMainMenu() && !IsGameOver() && !IsGamePaused();
    }

    private bool IsGamePaused()
    {
        return Time.timeScale == 0f; // Проверяем, остановлено ли время
    }
}
