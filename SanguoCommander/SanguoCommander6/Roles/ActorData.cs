namespace SanguoCommander.Roles
{
    enum ActorType
    {
        None, Soldier,Hero
    }
    enum ActorPro
    {
        None, Infantry, Pikeman, Cavalvy, Archer
    }
    enum ActorDir
    {
        None, Right, Left
    }
    class ActorData
    {
        public ActorData(string id)
        {
            ActorID = id;
        }
        //演员id
        public string ActorID { get; private set; }
        //演员分组
        public string GroupID { get; private set; }
        //类型
        public ActorType ActorType { get; private set; }
        //职业
        public ActorPro ActorPro { get; private set; }
        //获得一个数据
        public static ActorData getActorData(string id, string groupid, ActorType type, ActorPro pro)
        {
            ActorData data = new ActorData(id);
            data.GroupID = groupid;
            data.ActorType = type;
            data.ActorPro = pro;
            return data;
        }
    }
}
