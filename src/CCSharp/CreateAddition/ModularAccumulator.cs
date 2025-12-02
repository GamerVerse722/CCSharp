using CCSharp.Attributes;
using CCSharp.ComputerCraft.Peripherals;

namespace CCSharp.CreateAddition;

[LuaImplicitTypeArgument("modular_accumulator")]
public class ModularAccumulator : CCPeripheral
{
    [LuaMethod("getEnergy")]
    public int GetEnergy() => default;

    [LuaMethod("getCapacity")]
    public int GetCapacity() => default;

    [LuaMethod("getPercent")]
    public float GetPercent() => default;

    [LuaMethod("getMaxInsert")]
    public int GetMaxInsert() => default;

    [LuaMethod("getMaxExtract")]
    public int GetMaxExtract() => default;

    [LuaMethod("getHeight")]
    public int GetHeight() => default;

    [LuaMethod("getWidth")]
    public int GetWidth() => default;
}