﻿using ProtoBuf;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_Passage : MyObjectBuilder_CubeBlock
    {
    }
}
