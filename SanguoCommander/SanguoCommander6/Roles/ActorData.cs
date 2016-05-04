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
        //��Աid
        public string ActorID { get; private set; }
        //��Ա����
        public string GroupID { get; private set; }
        //����
        public ActorType ActorType { get; private set; }
        //ְҵ
        public ActorPro ActorPro { get; private set; }
        //���һ������
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
