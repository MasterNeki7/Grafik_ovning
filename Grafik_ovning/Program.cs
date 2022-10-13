using Raylib_cs;

Raylib.InitWindow(800, 600, "grafiktest");
Raylib.SetTargetFPS(60);

Color hotPink = new Color(255, 105, 180, 255);
Color whitepink = new Color(245, 160, 233, 255);

Rectangle playerRect = new Rectangle(0, 0, 64, 64);

while (Raylib.WindowShouldClose() == false)
{
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        playerRect.x += 2;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        playerRect.y += 2;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        playerRect.x -= 2;
    }
    else if ((Raylib.IsKeyDown(KeyboardKey.KEY_W)))
    {
        playerRect.y -= 2;
    }


    Raylib.BeginDrawing();
    Raylib.ClearBackground(hotPink);

    Raylib.DrawRectangleRec(playerRect, whitepink);



    Raylib.EndDrawing();
}



