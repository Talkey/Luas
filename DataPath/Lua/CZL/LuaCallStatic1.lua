--lua���þ�̬��
--����""CS.�����ռ�.��������Ա������"
print("hello")
print("hello1")

print("houbiande��ӡid�ţ�"..CS.LuaNameSpace.LuaStaticClass.id)
--[[
--��̬���Ը�ֵ
CS.LuaNameSpace.LuaStaticClass.name="admin"
print("����:"..CS.LuaNameSpace.LuaStaticClass.name)

--��̬��Ա����
print("��̬��Ա����:"..CS.LuaNameSpace.LuaStaticClass.outPut())

--ʹ��Ĭ��ֵ
CS.LuaNameSpace.LuaStaticClass.Defualt()
--ʹ���Զ���ֵ
local strs="iwanna"
CS.LuaNameSpace.LuaStaticClass.Defualt("�Զ���ֵ:"..strs)
]]