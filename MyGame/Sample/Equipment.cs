// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame.Sample
{

public enum Equipment : byte
{
  NONE = 0,
  Function1 = 1,
  Object1 = 2,
};



static public class EquipmentVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, byte typeId, uint tablePos)
  {
    bool result = true;
    switch((Equipment)typeId)
    {
      case Equipment.Function1:
        result = MyGame.Sample.Function1Verify.Verify(verifier, tablePos);
        break;
      case Equipment.Object1:
        result = MyGame.Sample.Object1Verify.Verify(verifier, tablePos);
        break;
      default: result = true;
        break;
    }
    return result;
  }
}


}
