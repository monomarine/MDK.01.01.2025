using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class BuilderDirector
    {
        public BuilderDirector()
        {
            
        }

        public GameCharacter CreateWarrior(string name, int level)
        {
            return new CharacterBuilder()
                .SetName(name)
                .SetClass(CharacterClass.Warrior)
                .SetLevel(level)
                .SetAppirance("воин")
                .SetWeapon("меч")
                .SetArmor("кольчуга")
                 .AddSkill("сильный удар")
                .AddSkill("защита")
                 .AddSkill("атака с разбега")
                .Build(); 
        }

        public GameCharacter CreateNPC(string name, CharacterClass npcClass, string role)
        {
            var builder = new CharacterBuilder()
        .SetName(name)
        .SetClass(npcClass)
        .SetLevel(5);

            switch (role)
            {
                case "Торговец":
                    builder.SetWeapon("трость")
                          .SetArmor("одежда")
                          .AddSkill("торговля")
                          .AddSkill("убеждение");
                    break;
                case "Стражник":
                    builder.SetWeapon("копье")
                          .SetArmor("броня")
                          .AddSkill("бдительность")
                          .AddSkill("задержание");
                    break;
                case "Целитель":
                    builder.SetWeapon("посох")
                          .SetArmor("робы")
                          .AddSkill("исцеление")
                          .AddSkill("снятие проклятий");
                    break;
                case "Кузнец":
                    builder.SetWeapon("молот")
                          .SetArmor("фартук")
                          .AddSkill("кузнечное дело")
                          .AddSkill("ремонт оружия");
                    break;
            }

            return builder.Build();
        }
    }
}
