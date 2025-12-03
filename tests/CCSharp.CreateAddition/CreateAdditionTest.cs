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
        
        Console.WriteLine("---Digital Adapter---");
        DigitalAdapter displayLink = Peripheral.Wrap<DigitalAdapter>("digital_adapter_0");
        displayLink.ClearLine();
        displayLink.Clear();
        displayLink.Print("Testing");
        Console.WriteLine(displayLink.GetLine());
        Console.WriteLine(displayLink.SetLine(1));
        Console.WriteLine(displayLink.GetMaxLines());

        DigitalAdapter speedController = Peripheral.Wrap<DigitalAdapter>("digital_adapter_1");
        speedController.SetTargetSpeed("east",-67);
        Console.WriteLine("east");
        
        DigitalAdapter stressGauge = Peripheral.Wrap<DigitalAdapter>("digital_adapter_2");
        Console.WriteLine(stressGauge.GetKineticStress("east"));
        Console.WriteLine(stressGauge.GetKineticCapacity("east"));
        
        DigitalAdapter speedGauge = Peripheral.Wrap<DigitalAdapter>("digital_adapter_3");
        Console.WriteLine(speedGauge.GetKineticSpeed("east"));
        Console.WriteLine(speedGauge.GetKineticTopSpeed("east"));
        
        DigitalAdapter hosePully = Peripheral.Wrap<DigitalAdapter>("digital_adapter_4");
        Console.WriteLine(hosePully.GetPulleyDistance("east"));
        
        DigitalAdapter mechanicalPiston = Peripheral.Wrap<DigitalAdapter>("digital_adapter_5");
        Console.WriteLine(mechanicalPiston.GetPistonDistance("east"));
        
        DigitalAdapter mechanicalBearing = Peripheral.Wrap<DigitalAdapter>("digital_adapter_6");
        Console.WriteLine(mechanicalBearing.GetBearingAngle("east"));
        
        DigitalAdapter elevatorPully = Peripheral.Wrap<DigitalAdapter>("digital_adapter_7");
        Console.WriteLine(elevatorPully.GetElevatorFloor("east"));
        Console.WriteLine(elevatorPully.HasElevatorArrived("east"));
        Console.WriteLine(elevatorPully.GetElevatorFloors("east"));
        Console.WriteLine(elevatorPully.GetElevatorFloorName("east", 1));
        Console.WriteLine(elevatorPully.GoToElevatorFloor("east", 1));

        DigitalAdapter digitalElectricMotor = Peripheral.Wrap<DigitalAdapter>("digital_adapter_8");
        Console.WriteLine(digitalElectricMotor.GetDurationAngle(20, 50));
        Console.WriteLine(digitalElectricMotor.GetDurationDistance(5, 37));
    }
}