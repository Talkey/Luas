--lua调用静态类
--规则""CS.命名空间.类名。成员变量名"
print("hello")
print("打印id号："..CS.LuaNameSpace.LuaStaticClass.id)

--静态属性赋值?
CS.LuaNameSpace.LuaStaticClass.name="admin"
print("名字:"..CS.LuaNameSpace.LuaStaticClass.name)

--静态成员方法?
print("静态成员方法?:"..CS.LuaNameSpace.LuaStaticClass.outPut())

--使用默认函数?
CS.LuaNameSpace.LuaStaticClass.Defualt()
--使用自定义函数?
local strs="iwanna"
CS.LuaNameSpace.LuaStaticClass.Defualt("自定义函数?:"..strs)