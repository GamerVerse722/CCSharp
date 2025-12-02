using CCSharp.Attributes;
using CCSharp.ComputerCraft.Peripherals;

namespace CCSharp.CreateAddition;

[LuaImplicitTypeArgument("redstone_relay")]
public class RedstoneRelay : CCPeripheral
{
    [LuaMethod("getMaxInsert")]
    public int GetMaxInsert() => default;

    [LuaMethod("getMaxExtract")]
    public int GetMaxExtract() => default;
    
    [LuaMethod("getThroughput")]
    public int GetThroughput() => default;
    
    [LuaMethod("isPowered")]
    public bool IsPowered() => default;
}