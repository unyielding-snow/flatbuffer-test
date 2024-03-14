-- https://flatbuffers.dev/flatbuffers_guide_tutorial.html
-- writing flatbuffers (think of them as objects of a class)
-- this can be saved, and potentially sent over a netowrk.

-- require the flatbuffers module
local flatbuffers = require("flatbuffers")
 
-- require the generated files from `flatc`.
local color = require("MyGame.Sample.Color")
local equipment = require("MyGame.Sample.Equipment")
local monster = require("MyGame.Sample.Function1")
local vec3 = require("MyGame.Sample.Vec3")
local weapon = require("MyGame.Sample.Object1")


-- CREATING & WRITING OBJECT FLATBUFFERS FROM CLASSES 
-- creates an instance of flatbuffer builder, which will contain the buffer as it grows
-- get access to the builder, providing an array of size 1024 (intial bytes)
local builder = flatbuffers.Builder(1024)


-- CREATE FLATBUFFERS for object1
local weaponOne = builder:CreateString("Sword")
local weaponTwo = builder:CreateString("Axe")
 
-- Create the first object of Object1, which is a weapon
object1.Start(builder)
object1.AddName(builder, weaponOne)
object1.AddDamage(builder, 3)
local sword = weapon.End(builder)
 
-- Create the second object
object1.Start(builder)
object1.AddName(builder, weaponTwo)
object1.AddDamage(builder, 5)
local axe = weapon.End(builder)

-- CREATE FLATBUFFERS FOR FUNCTION1
local name = builder:CreateString("temp")

-- Create a `vector` (built in flatbuffer data type)
-- **NOTE: We prepend the bytes, so the loop iterates in reverse.

function1.StartInventoryVector(builder, 10)
for i=10,1,-1 do
    builder:PrependByte(i)
end
local inv = builder:EndVector(10)

-- these values are offsets 
-- create a FlatBuffer vector and prepend the weapons.
-- note: Since we prepend the data, prepend them in reverse order.
monster.StartWeaponsVector(builder, 2)
builder:PrependUOffsetTRelative(axe)
builder:PrependUOffsetTRelative(sword)
local weapons = builder:EndVector(2)


monster.StartPathVector(builder, 2)
vec3.CreateVec3(builder, 1.0, 2.0, 3.0)
vec3.CreateVec3(builder, 4.0, 5.0, 6.0)
local path = builder:EndVector(2)

-- FINALLY FINISH CREATION
-- Create our monster by using Start() andEnd()
function1.Start(builder)
function1.AddPos(builder, vec3.CreateVec3(builder, 1.0, 2.0, 3.0))
function1.AddHp(builder, 300)
function1.AddName(builder, name)
function1.AddInventory(builder, inv)
function1.AddColor(builder, color.Red)
function1.AddWeapons(builder, weapons)
function1.AddEquippedType(builder, equipment.Weapon)
function1.AddEquipped(builder, axe)
function1.AddPath(builder, path)
local orc = monster.End(builder)

