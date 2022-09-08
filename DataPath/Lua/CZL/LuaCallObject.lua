--lua实例化一个类
--C#
local  obj=CS.NPC()

obj.HP=100;
print(obj.HP)
--print(CS.obj.PrintMe())

local NPC0=CS.NPC("wangzeyuan")
print(NPC0.name)

--表方法调用表成员变量
NPC0:PrintMe()
print(NPC0:output().."第二次打印")





CS.UnityEngine.GameObject("GameObjectLuaCreated")