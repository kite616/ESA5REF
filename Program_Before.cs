namespace ESA5Before
{
    class Player
    {
        public Player(int id = 0, string name = "Player", int health = 1, int weaponDamage = 0, int weaponTypeId = 0)
        {
            Id = id;
            Name = name;
            Health = health;
            WeaponDamage = weaponDamage;
            WeaponTypeId = weaponTypeId;
        }

        private int Id
        { get; set; }
        private string Name
        { get; set; }
        private int Health
        { get; set; }
        private int WeaponDamage
        { get; set; }
        private int WeaponTypeId
        { get; set; }
        private int TargetId
        { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public int DealDamage()
        {
            return WeaponDamage * WeaponTypeId;
        }

        public void SpeakToTarget()
        {
            //
        }
    }

    class Npc
    {
        public Npc(int id = 0, string name = "NPC", int health = 1, int weaponDamage = 0, int weaponTypeId = 0)
        {
            Id = id;
            Name = name;
            Health = health;
            WeaponDamage = weaponDamage;
            WeaponTypeId = weaponTypeId;
        }

        private int Id
        { get; set; }
        private string Name
        { get; set; }
        private int Health
        { get; set; }
        private int WeaponDamage
        { get; set; }
        private int WeaponTypeId
        { get; set; }
        private int TargetId
        { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public int DealDamage()
        {
            return WeaponDamage * WeaponTypeId;
        }

        public string giveNextQuest()
        {
            return "QuestTitle";
        }
    }
}