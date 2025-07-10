#include <iostream>
#include <vector>
#include <conio.h>  // for _getch()
#include <cstdlib>  // for system("cls")
#include <Windows.h> // for cursor disabling

using namespace std;

const int HEIGHT = 10;
const int WIDTH = 20;

char map[HEIGHT][WIDTH + 1] = 
{
    "###################",
    "#P   *#      *  #E#",
    "# ### ########### #",
    "#   #     *#*   # #",
    "### ########### # #",
    "#   #         # # #",
    "# # ### # ###   # #",
    "# #     # ####### #",
    "#*#######         #",
    "###################"
};

int playerX = 1, playerY = 1;
int starCount = 0;

// Function prototypes
void HideCursor();
void drawMap();
void movePlayer(int moveX, int moveY);

int main() {
    
	HideCursor(); // Hide the console cursor for a cleaner look
    
    while (true) {
        drawMap();
		char input = _getch(); // Get user input without waiting for Enter key

        switch (input) {
            case 'w': movePlayer(0, -1); break;
            case 's': movePlayer(0, 1); break;
            case 'a': movePlayer(-1, 0); break;
            case 'd': movePlayer(1, 0); break;
        }
    }
    return 0;
}

void HideCursor() {
    HANDLE hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
    CONSOLE_CURSOR_INFO cursorInfo;

    GetConsoleCursorInfo(hConsole, &cursorInfo);
    cursorInfo.bVisible = FALSE;
    SetConsoleCursorInfo(hConsole, &cursorInfo);
}

void drawMap() {
	system("cls"); // Clear the console
    for (int i = 0; i < HEIGHT; ++i) {
        cout << map[i] << endl;
    }
    cout << "\nStars Collected: " << starCount << endl;
}

void movePlayer(int moveX, int moveY) {
    int newX = playerX + moveX;
    int newY = playerY + moveY;

    char location = map[newY][newX];
    if (location == '#' || location == '\0') {
        return;
    }

    if (location == '*') {
        starCount++;
    }
    if (location == 'E') {
        map[playerY][playerX] = ' ';
        playerX = newX;
        playerY = newY;
        map[playerY][playerX] = 'P';
        drawMap();
        cout << "\nYou escaped the maze!\nTotal stars collected: " << starCount << endl;
        exit(0);
    }

	map[playerY][playerX] = ' '; // Clear the old position
	playerX = newX; // Update player position X
	playerY = newY; // Update player position Y
	map[playerY][playerX] = 'P'; // Set the player after cleaning
}


