using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft;
using CCSharp.CreateAddition;

namespace CCSharp.Tests;

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
        Console.WriteLine(electricMotor.GetMaxExtract());
        
        Console.WriteLine("---Modular Accumulator---");

        ModularAccumulator modularAccumulator = Peripheral.Find<ModularAccumulator>();
        Console.WriteLine(modularAccumulator.GetEnergy());
        Console.WriteLine(modularAccumulator.GetCapacity());
        Console.WriteLine(modularAccumulator.GetPercent());
        Console.WriteLine(modularAccumulator.GetMaxInsert());
        Console.WriteLine(modularAccumulator.GetMaxExtract());
        Console.WriteLine(modularAccumulator.GetHeight());
        Console.WriteLine(modularAccumulator.GetWidth());
        
        Console.WriteLine("---Redstone Relay---");

        RedstoneRelay redstoneRelay = Peripheral.Find<RedstoneRelay>();
        Console.WriteLine(redstoneRelay.GetMaxInsert());
        Console.WriteLine(redstoneRelay.GetMaxExtract());
        Console.WriteLine(redstoneRelay.GetThroughput());
        Console.WriteLine(redstoneRelay.IsPowered());
        
        Console.WriteLine("---Portable Energy Interface---");

        PortableEnergyInterface portableEnergyInterface = Peripheral.Find<PortableEnergyInterface>();
        Console.WriteLine(portableEnergyInterface.GetEnergy());
        Console.WriteLine(portableEnergyInterface.GetCapacity());
        Console.WriteLine(portableEnergyInterface.IsConnected());
        Console.WriteLine(portableEnergyInterface.GetMaxInsert());
        Console.WriteLine(portableEnergyInterface.GetMaxExtract());
    }
}