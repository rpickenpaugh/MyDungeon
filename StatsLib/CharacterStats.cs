using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsLib
{
    public class CharacterStats
    {   //fields
        private string _characterName;
        private string _characterRace;
        private string _characterClass;
        private int _characterStrength;
        private int _characterDexterity;
        private int _characterConstitution;
        private int _characterIntellect;
        private int _characterDefense;
        private decimal _characterCritical;
        private decimal _characterDodge;
        private int _characterLuck;
        private decimal _characterBlock;
        private int _characterExp;
        private int _characterCurrentHp;
        private int _characterCurrentMp;

        //properties
        public string CharacterName
        {
            get { return _characterName; }
            set { _characterName = value; }
        }
        public string CharacterRace
        {
            get { return _characterRace; }
            set { _characterRace = value; }
        }
        public string CharacterClass
        {
            get { return _characterClass; }
            set { _characterClass = value; }
        }
        private int CharacterStrength
        {
            get { return _characterStrength; }
            set { _characterStrength = value; }
        }
        private int CharacterDexterity
        {
            get { return _characterDexterity; }
            set { _characterDexterity = value; }
        }
        private int CharacterConstitution
        {
            get { return _characterConstitution; }
            set { _characterConstitution = value; }
        }
        private int CharacterIntellect
        {
            get { return _characterIntellect; }
            set { _characterIntellect = value; }
        }
        private int CharacterDefense
        {
            get { return _characterDefense; }
            set { _characterDefense = value; }
        }
        private decimal CharacterCritical
        {
            get { return _characterCritical; }
            set { _characterCritical = value; }
        }
        private decimal CharacterDodge
        {
            get { return _characterDodge; }
            set { _characterDodge = value; }
        }
        private int CharacterLuck
        {
            get { return _characterLuck; }
            set { _characterLuck = value; }
        }
        private decimal CharacterBlock
        {
            get { return _characterBlock; }
            set { _characterBlock = value; }
        }
        private int CharacterExp
        {
            get { return _characterExp; }
            set { _characterExp = value; }
        }
        private int CharacterCurrentHp
        {
            get { return _characterCurrentHp; }
            set { _characterCurrentHp = value; }
        }
        private int CharacterCurrentMP
        {
            get { return _characterCurrentMp; }
            set { _characterCurrentMp = value; }
        }
        //constructors
        public CharacterStats(string characterName, string characterRace, string characterClass, int characterStrength, int characterDexterity, int characterCurrentHp, int characterConstitution, int characterCurrentMp, int characterIntellect, int characterDefense,
            decimal characterCritical, decimal characterDodge, int characterLuck, decimal characterBlock)
        {
            CharacterName = characterName;
            CharacterRace = characterRace;
            CharacterClass = characterClass;
            CharacterStrength = characterStrength;
            CharacterDexterity = characterDexterity;
            CharacterCurrentHp = characterCurrentHp;
            CharacterConstitution = characterConstitution;
            CharacterCurrentMP = characterCurrentMp;
            CharacterIntellect = characterIntellect;
            CharacterDefense = characterDefense;
            CharacterCritical = characterCritical;
            CharacterDodge = characterDodge;
            CharacterLuck = characterLuck;
            CharacterBlock = characterBlock;
        }
        public CharacterStats()
        {

        }
        //methods
        //public override string ToString()
        //{
        //    return string.Format("Name: {0}\nRace: {1}\nClass: {2}\n\nAttributes:\n\n" +

        //        "HP: {3}\tMP: {4}\nStrength: {5}\tDexterity: {6}\nDefense: {7}\tLuck: {8}\nCritical: {9:n2}%\nDodge: {10:n2}%\nBlock: {11:n2}%",

        //        CharacterName, CharacterClass, CharacterRace,

        //        CharacterConstitution,
        //        CharacterIntellect,
        //        CharacterStrength,
        //        CharacterDexterity,
        //        CharacterDefense,
        //        CharacterLuck,
        //        CharacterCritical,
        //        CharacterDodge,
        //        CharacterBlock);
        //}
        public override string ToString()
        {
            return string.Concat(
                "HP: " + CharacterCurrentHp + " / " + CharacterConstitution + "\t" +
                "MP: " + CharacterCurrentMP + " / " + CharacterIntellect + "\n\n" +
                "Strength: " + CharacterStrength + "\t" +
                "Dexterity: " + CharacterDexterity + "\n" +
                "Defense: " + CharacterDefense + "\t" +
                "Luck: " + CharacterLuck + "\n" +
                "Critical: " + CharacterCritical + "\t" +
                "Dodge: " + CharacterDodge + "\n" +
                "Block: " + CharacterBlock
                );
        }

    }//end class
}//end namespace
