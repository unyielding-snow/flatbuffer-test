// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame.Sample
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct Function1 : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_7(); }
  public static Function1 GetRootAsFunction1(ByteBuffer _bb) { return GetRootAsFunction1(_bb, new Function1()); }
  public static Function1 GetRootAsFunction1(ByteBuffer _bb, Function1 obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool VerifyFunction1(ByteBuffer _bb) {Google.FlatBuffers.Verifier verifier = new Google.FlatBuffers.Verifier(_bb); return verifier.VerifyBuffer("", false, Function1Verify.Verify); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public Function1 __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public MyGame.Sample.Vec3? Pos { get { int o = __p.__offset(4); return o != 0 ? (MyGame.Sample.Vec3?)(new MyGame.Sample.Vec3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public short Mana { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)150; } }
  public short Hp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetShort(o + __p.bb_pos) : (short)100; } }
  public string Name { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(10); }
  public byte Inventory(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int InventoryLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetInventoryBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetInventoryBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetInventoryArray() { return __p.__vector_as_array<byte>(14); }
  public MyGame.Sample.Color Color { get { int o = __p.__offset(16); return o != 0 ? (MyGame.Sample.Color)__p.bb.GetSbyte(o + __p.bb_pos) : MyGame.Sample.Color.Blue; } }
  public MyGame.Sample.Object1? Weapons(int j) { int o = __p.__offset(18); return o != 0 ? (MyGame.Sample.Object1?)(new MyGame.Sample.Object1()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int WeaponsLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public MyGame.Sample.Equipment EquippedType { get { int o = __p.__offset(20); return o != 0 ? (MyGame.Sample.Equipment)__p.bb.Get(o + __p.bb_pos) : MyGame.Sample.Equipment.NONE; } }
  public TTable? Equipped<TTable>() where TTable : struct, IFlatbufferObject { int o = __p.__offset(22); return o != 0 ? (TTable?)__p.__union<TTable>(o + __p.bb_pos) : null; }
  public MyGame.Sample.Function1 EquippedAsFunction1() { return Equipped<MyGame.Sample.Function1>().Value; }
  public MyGame.Sample.Object1 EquippedAsObject1() { return Equipped<MyGame.Sample.Object1>().Value; }
  public MyGame.Sample.Vec3? Path(int j) { int o = __p.__offset(24); return o != 0 ? (MyGame.Sample.Vec3?)(new MyGame.Sample.Vec3()).__assign(__p.__vector(o) + j * 12, __p.bb) : null; }
  public int PathLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static void StartFunction1(FlatBufferBuilder builder) { builder.StartTable(11); }
  public static void AddPos(FlatBufferBuilder builder, Offset<MyGame.Sample.Vec3> posOffset) { builder.AddStruct(0, posOffset.Value, 0); }
  public static void AddMana(FlatBufferBuilder builder, short mana) { builder.AddShort(1, mana, 150); }
  public static void AddHp(FlatBufferBuilder builder, short hp) { builder.AddShort(2, hp, 100); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(3, nameOffset.Value, 0); }
  public static void AddInventory(FlatBufferBuilder builder, VectorOffset inventoryOffset) { builder.AddOffset(5, inventoryOffset.Value, 0); }
  public static VectorOffset CreateInventoryVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateInventoryVectorBlock(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInventoryVectorBlock(FlatBufferBuilder builder, ArraySegment<byte> data) { builder.StartVector(1, data.Count, 1); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateInventoryVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<byte>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartInventoryVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddColor(FlatBufferBuilder builder, MyGame.Sample.Color color) { builder.AddSbyte(6, (sbyte)color, 2); }
  public static void AddWeapons(FlatBufferBuilder builder, VectorOffset weaponsOffset) { builder.AddOffset(7, weaponsOffset.Value, 0); }
  public static VectorOffset CreateWeaponsVector(FlatBufferBuilder builder, Offset<MyGame.Sample.Object1>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateWeaponsVectorBlock(FlatBufferBuilder builder, Offset<MyGame.Sample.Object1>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWeaponsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<MyGame.Sample.Object1>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWeaponsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<MyGame.Sample.Object1>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartWeaponsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddEquippedType(FlatBufferBuilder builder, MyGame.Sample.Equipment equippedType) { builder.AddByte(8, (byte)equippedType, 0); }
  public static void AddEquipped(FlatBufferBuilder builder, int equippedOffset) { builder.AddOffset(9, equippedOffset, 0); }
  public static void AddPath(FlatBufferBuilder builder, VectorOffset pathOffset) { builder.AddOffset(10, pathOffset.Value, 0); }
  public static void StartPathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(12, numElems, 4); }
  public static Offset<MyGame.Sample.Function1> EndFunction1(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<MyGame.Sample.Function1>(o);
  }
  public static void FinishFunction1Buffer(FlatBufferBuilder builder, Offset<MyGame.Sample.Function1> offset) { builder.Finish(offset.Value); }
  public static void FinishSizePrefixedFunction1Buffer(FlatBufferBuilder builder, Offset<MyGame.Sample.Function1> offset) { builder.FinishSizePrefixed(offset.Value); }
}


static public class Function1Verify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Pos*/, 12 /*MyGame.Sample.Vec3*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*Mana*/, 2 /*short*/, 2, false)
      && verifier.VerifyField(tablePos, 8 /*Hp*/, 2 /*short*/, 2, false)
      && verifier.VerifyString(tablePos, 10 /*Name*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*Inventory*/, 1 /*byte*/, false)
      && verifier.VerifyField(tablePos, 16 /*Color*/, 1 /*MyGame.Sample.Color*/, 1, false)
      && verifier.VerifyVectorOfTables(tablePos, 18 /*Weapons*/, MyGame.Sample.Object1Verify.Verify, false)
      && verifier.VerifyField(tablePos, 20 /*EquippedType*/, 1 /*MyGame.Sample.Equipment*/, 1, false)
      && verifier.VerifyUnion(tablePos, 20, 22 /*Equipped*/, MyGame.Sample.EquipmentVerify.Verify, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*Path*/, 12 /*MyGame.Sample.Vec3*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
