namespace Tomato
{
    public class CardTypes
    {
        public string Attack => "Attack";
        public string Defense => "Defense";
        public string Resist => "Resist";
        public string Proc => "Proc";
        public string Utility => "Utility";
    }
    // 'attack': ['damage', 'critical', 'DOT', 'multistrike'],
    // 'defense': ['absorb', 'dodge', 'block'],
    // 'resist': ['electricial', 'fire', 'nature', 'shadow', 'cold'],
    // 'proc': ['electricial', 'fire', 'nature', 'shadow', 'cold', 'chaos'],
    // 'utility' : ['freeze','stun','stealth']

}