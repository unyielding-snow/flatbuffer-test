--[[ MyGame.Sample.Function1

  Automatically generated by the FlatBuffers compiler, do not modify.
  Or modify. I'm a message, not a cop.

  flatc version: 24.3.7

  Declared by  : 
  Rooting type : MyGame.Sample.Function1 ()

--]]

local __MyGame_Sample_Object1 = require('MyGame.Sample.Object1')
local __MyGame_Sample_Vec3 = require('MyGame.Sample.Vec3')
local flatbuffers = require('flatbuffers')

local Function1 = {}
local mt = {}

function Function1.New()
  local o = {}
  setmetatable(o, {__index = mt})
  return o
end

function Function1.GetRootAsFunction1(buf, offset)
  if type(buf) == "string" then
    buf = flatbuffers.binaryArray.New(buf)
  end

  local n = flatbuffers.N.UOffsetT:Unpack(buf, offset)
  local o = Function1.New()
  o:Init(buf, n + offset)
  return o
end

function mt:Init(buf, pos)
  self.view = flatbuffers.view.New(buf, pos)
end

function mt:Pos()
  local o = self.view:Offset(4)
  if o ~= 0 then
    local x = self.view.pos + o
    local obj = __MyGame_Sample_Vec3.New()
    obj:Init(self.view.bytes, x)
    return obj
  end
end

function mt:Mana()
  local o = self.view:Offset(6)
  if o ~= 0 then
    return self.view:Get(flatbuffers.N.Int16, self.view.pos + o)
  end
  return 150
end

function mt:Hp()
  local o = self.view:Offset(8)
  if o ~= 0 then
    return self.view:Get(flatbuffers.N.Int16, self.view.pos + o)
  end
  return 100
end

function mt:Name()
  local o = self.view:Offset(10)
  if o ~= 0 then
    return self.view:String(self.view.pos + o)
  end
end

function mt:Inventory(j)
  local o = self.view:Offset(14)
  if o ~= 0 then
    local a = self.view:Vector(o)
    return self.view:Get(flatbuffers.N.Uint8, a + ((j-1) * 1))
  end
  return 0
end

function mt:InventoryAsString(start, stop)
  return self.view:VectorAsString(14, start, stop)
end

function mt:InventoryLength()
  local o = self.view:Offset(14)
  if o ~= 0 then
    return self.view:VectorLen(o)
  end
  return 0
end

function mt:Color()
  local o = self.view:Offset(16)
  if o ~= 0 then
    return self.view:Get(flatbuffers.N.Int8, self.view.pos + o)
  end
  return 2
end

function mt:Weapons(j)
  local o = self.view:Offset(18)
  if o ~= 0 then
    local x = self.view:Vector(o)
    x = x + ((j-1) * 4)
    x = self.view:Indirect(x)
    local obj = __MyGame_Sample_Object1.New()
    obj:Init(self.view.bytes, x)
    return obj
  end
end

function mt:WeaponsLength()
  local o = self.view:Offset(18)
  if o ~= 0 then
    return self.view:VectorLen(o)
  end
  return 0
end

function mt:EquippedType()
  local o = self.view:Offset(20)
  if o ~= 0 then
    return self.view:Get(flatbuffers.N.Uint8, self.view.pos + o)
  end
  return 0
end

function mt:Equipped()
  local o = self.view:Offset(22)
  if o ~= 0 then
   local obj = flatbuffers.view.New(flatbuffers.binaryArray.New(0), 0)
    self.view:Union(obj, o)
    return obj
  end
end

function mt:Path(j)
  local o = self.view:Offset(24)
  if o ~= 0 then
    local x = self.view:Vector(o)
    x = x + ((j-1) * 12)
    local obj = __MyGame_Sample_Vec3.New()
    obj:Init(self.view.bytes, x)
    return obj
  end
end

function mt:PathLength()
  local o = self.view:Offset(24)
  if o ~= 0 then
    return self.view:VectorLen(o)
  end
  return 0
end

function Function1.Start(builder)
  builder:StartObject(11)
end

function Function1.AddPos(builder, pos)
  builder:PrependStructSlot(0, pos, 0)
end

function Function1.AddMana(builder, mana)
  builder:PrependInt16Slot(1, mana, 150)
end

function Function1.AddHp(builder, hp)
  builder:PrependInt16Slot(2, hp, 100)
end

function Function1.AddName(builder, name)
  builder:PrependUOffsetTRelativeSlot(3, name, 0)
end

function Function1.AddInventory(builder, inventory)
  builder:PrependUOffsetTRelativeSlot(5, inventory, 0)
end

function Function1.StartInventoryVector(builder, numElems)
  return builder:StartVector(1, numElems, 1)
end

function Function1.AddColor(builder, color)
  builder:PrependInt8Slot(6, color, 2)
end

function Function1.AddWeapons(builder, weapons)
  builder:PrependUOffsetTRelativeSlot(7, weapons, 0)
end

function Function1.StartWeaponsVector(builder, numElems)
  return builder:StartVector(4, numElems, 4)
end

function Function1.AddEquippedType(builder, equippedType)
  builder:PrependUint8Slot(8, equippedType, 0)
end

function Function1.AddEquipped(builder, equipped)
  builder:PrependUOffsetTRelativeSlot(9, equipped, 0)
end

function Function1.AddPath(builder, path)
  builder:PrependUOffsetTRelativeSlot(10, path, 0)
end

function Function1.StartPathVector(builder, numElems)
  return builder:StartVector(12, numElems, 4)
end

function Function1.End(builder)
  return builder:EndObject()
end

return Function1