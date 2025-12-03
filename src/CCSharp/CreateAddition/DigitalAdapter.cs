using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft.Peripherals;

namespace CCSharp.CreateAddition;

[LuaImplicitTypeArgument("digital_adapter")]
public class DigitalAdapter : CCPeripheral
{
    // Display Link
    [LuaMethod("clearLine")]
    public void ClearLine() {}
    
    [LuaMethod("clear")]
    public void Clear() {}
    
    [LuaMethod("print")]
    public void Print(String text) {}

    [LuaMethod("getLine")]
    public int GetLine() => default;
    
    [LuaMethod("setLine")]
    public int SetLine(int ln) => default;
    
    [LuaMethod("getMaxLines")]
    public int GetMaxLines() => default;
    
    // Speed Controller
    [LuaMethod("setTargetSpeed")]
    public void SetTargetSpeed(String direction, int speed) {}
    
    [LuaMethod("getTargetSpeed")]
    public int GetTargetSpeed(String direction) => default;
    
    // Stress Gauge
    [LuaMethod("getKineticStress")]
    public int GetKineticStress(String direction) => default;
    
    [LuaMethod("getKineticCapacity")]
    public int GetKineticCapacity(String direction) => default;
    
    // Speed Gauge
    [LuaMethod("getKineticSpeed")]
    public int GetKineticSpeed(String direction) => default;
    
    [LuaMethod("getKineticTopSpeed")]
    public int GetKineticTopSpeed(String direction) => default;
    
    // Pulley
    [LuaMethod("getPulleyDistance")]
    public int GetPulleyDistance(String direction) => default;
    
    [LuaMethod("getPistonDistance")]
    public int GetPistonDistance(String direction) => default;
    
    [LuaMethod("getBearingAngle")]
    public int GetBearingAngle(String direction) => default;
    
    [LuaMethod("getElevatorFloor")]
    public int GetElevatorFloor(String direction) => default;
    
    [LuaMethod("hasElevatorArrived")]
    public bool HasElevatorArrived(String direction) => default;
    
    [LuaMethod("getElevatorFloors")]
    public int GetElevatorFloors(String direction) => default;
    
    [LuaMethod("getElevatorFloorName")]
    public String GetElevatorFloorName(String direction, int index) => default;
    
    [LuaMethod("gotoElevatorFloor")]
    public int GoToElevatorFloor(String direction, int index) => default;
    
    [LuaMethod("getDurationAngle")]
    public float GetDurationAngle(int deg, int rpm) => default;
    
    [LuaMethod("getDurationDistance")]
    public float GetDurationDistance(int block, int rpm) => default;
    
}