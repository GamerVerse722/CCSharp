using System;
using CCSharp.Attributes;
using CCSharp.ComputerCraft.Peripherals;

namespace CCSharp.CreateAddition;

[LuaImplicitTypeArgument("electric_motor")]
public class ElectricMotor : CCPeripheral
{
    [LuaMethod("getType")]
    public String GetType() => default;

    [LuaMethod("setSpeed")]
    public void SetSpeed(double rpm) {}
    
    [LuaMethod("stop")]
    public String Stop() => default;

    [LuaMethod("getSpeed")]
    public float GetSpeed() => default;

    [LuaMethod("getStressCapacity")]
    public int GetStressCapacity() => default;

    [LuaMethod("getEnergyConsumption")]
    public float GetEnergyConsumption() => default;
    
    [LuaMethod("rotate")]
    public float Rotate(double deg, double rpm) => default;
    
    [LuaMethod("rotate")]
    public float Rotate(double deg) => default;
    
    [LuaMethod("translate")]
    public float Translate(double dist, double rpm) => default;
    
    [LuaMethod("translate")]
    public float Translate(double dist) => default;

    [LuaMethod("getMaxInsert")]
    public int GetMaxInsert() => default;

    [LuaMethod("getMaxExtract")]
    public int GetMaxExtract() => default;

}