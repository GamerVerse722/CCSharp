using CCSharp.Attributes;
using CCSharp.ComputerCraft.Peripherals;

namespace CCSharp.CreateAddition;

[LuaImplicitTypeArgument("portable_energy_interface")]
public class PortableEnergyInterface : CCPeripheral
{
    [LuaMethod("getEnergy")]
    public int GetEnergy() => default;
    
    [LuaMethod("getEnergy")]
    public int GetCapacity() => default;

    [LuaMethod("isConnected")]
    public bool IsConnected() => default;

    [LuaMethod("getMaxInsert")]
    public int GetMaxInsert() => default;

    [LuaMethod("getMaxExtract")]
    public int GetMaxExtract() => default;
}