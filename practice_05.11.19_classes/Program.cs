﻿using System;
using practice_05._11._19_classes.Task1_Figures;
using practice_05._11._19_classes.Task2_Plants;

namespace practice_05._11._19_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //FigureDrawing.DrawFigure();
            new Gallery(PlantList.GetPlantList(), new Worker()).Manage();
        }
    }
}