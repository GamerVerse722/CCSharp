using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft;
using CCSharp.CreateAddition;

namespace CCSharp.Demo;

[LuaProgram]
public class CreateAdditionTest
{
    [LuaMain]
    public static void Start()
    {
        Console.WriteLine("---Electric Motor---");
        
        ElectricMotor electricMotor = Peripheral.Find<ElectricMotor>();
        Console.WriteLine(electricMotor.GetType());
        electricMotor.SetSpeed(127);
        electricMotor.Stop();
        Console.WriteLine(electricMotor.GetSpeed());
        Console.WriteLine(electricMotor.GetStressCapacity());
        Console.WriteLine(electricMotor.GetEnergyConsumption());
        Console.WriteLine(electricMotor.Rotate(102.5, 127));
        Console.WriteLine(electricMotor.Translate(2, 21));
        Console.WriteLine(electricMotor.GetMaxInsert());
        Console.WriteLine(electricMotor.GetMaxInsert());
        
        Console.WriteLine("---Modular Accumulator---");

        ModularAccumulator modularAccumulator = Peripheral.Find<ModularAccumulator>();
        Console.WriteLine(modularAccumulator.GetEnergy());
        Console.WriteLine(modularAccumulator.GetCapacity());
        Console.WriteLine(modularAccumulator.GetPercent());
        Console.WriteLine(modularAccumulator.GetMaxInsert());
        Console.WriteLine(modularAccumulator.GetMaxExtract());
        Console.WriteLine(modularAccumulator.GetHeight());
        Console.WriteLine(modularAccumulator.GetWidth());
    }
}