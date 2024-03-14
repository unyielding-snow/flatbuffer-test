using FlatBuffers;
using MyGame.Sample; // The `flatc` generated files. (Monster, Vec3, etc.)

using System;
using System.IO;

// Create flat buffer builder
var builder = new FlatBufferBuilder(1024);

// Lets make weapon objects using our Object1 class
var weaponOneName = builder.CreateString("Sword");
var weaponOneDamage = 3;

var weaponTwoName = builder.CreateString("Axe");
var weaponTwoDamage = 5;

// Use the created `CreateObject1()` helper function to create new objects, since we set every field.
// You can see this in Object1.cs
var sword = Object1.CreateObject1(builder, weaponOneName, (short)weaponOneDamage);
var axe = Object1.CreateObject1(builder, weaponTwoName, (short)weaponTwoDamage);

// Serialize a name for our function
var name = builder.CreateString("func");

// Create a `vector` representing a list in the function
// could correspond to an item that can be claimed after he is slain.
// Note: Since we prepend the bytes, this loop iterates in reverse order.
Function1.StartInventoryVector(builder, 10);
for (int i = 9; i >= 0; i--)
{
	builder.AddByte((byte)i);
}
var inv = builder.EndVector();

var weaps = new Offset<Weapon>[2];
weaps[0] = sword;
weaps[1] = axe;

// Pass the `weaps` array into the `CreateWeaponsVector()` method to create a FlatBuffer vector.
var weapons = Monster.CreateWeaponsVector(builder, weaps);

Function1.StartPathVector(fbb, 2);
Vec3.CreateVec3(builder, 1.0f, 2.0f, 3.0f);
Vec3.CreateVec3(builder, 4.0f, 5.0f, 6.0f);
var path = fbb.EndVector();

Function1.StartMonster(builder);
Function1.AddPos(builder, Vec3.CreateVec3(builder, 1.0f, 2.0f, 3.0f));
Function1.AddHp(builder, (short)300);
Function1.AddName(builder, name);
Function1.AddInventory(builder, inv);
Function1.AddColor(builder, Color.Red);
Function1.AddWeapons(builder, weapons);
Function1.AddEquippedType(builder, Equipment.Weapon);
Function1.AddEquipped(builder, axe.Value); 
Function1.AddPath(builder, path);
var func1 = Function1.EndMonster(builder);

// Make sure your file mode (or transfer protocol) is set to BINARY, not text.
// Now you can write the bytes to a file or send them over the network
// Call `Finish()` to instruct the builder that this monster is complete.
builder.Finish(func1.Value); // You could also call `Function1.FinishFunction1Buffer(builder, func1);`.

byte[] buf = builder.SizedByteArray();

// Now you can write these bytes to a file and store / send them away
string filepath = "written_buffer_cs.txt"

StreamWriter writer = new StreamWriter(filepath);
writer.WriteLine(buf);