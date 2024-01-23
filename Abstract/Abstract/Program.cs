﻿using Abstract;

var radius = int.Parse(Console.ReadLine());
IDraw circle = new Circle(radius);

var width = int.Parse(Console.ReadLine());
var height = int.Parse(Console.ReadLine());
IDraw rect = new Rectangle(width, height);

circle.Draw();
rect.Draw();