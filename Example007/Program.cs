﻿Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 1, ya = 1,
    xb = 1, yb = 10,
    xc = 10, yc = 10;

Console.SetCursorPosition(xa, ya);    
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);    
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);    
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while(count < 10)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        
    }
}