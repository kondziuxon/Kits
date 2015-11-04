using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;
using System;

namespace fr34kyn01535.Kits
{
    public class KitsConfiguration : IRocketPluginConfiguration
    {
        [XmlArrayItem(ElementName = "Kit")]
        public List<Kit> Kits;
        public int GlobalCooldown;

        public void LoadDefaults()
        {
            GlobalCooldown = 10;
            Kits = new List<Kit>() {
                new Kit() { Cooldown = 10, Name = "starter", Items = new List<KitItem>() { new KitItem(105, 1), new KitItem(14, 1), new KitItem(13, 1), new KitItem(276, 1), new KitItem(9, 1) <chance>30</chance> }},
            };
        }
    }

    public class Kit
    {
        public Kit() { }

        public string Name;

        [XmlArrayItem(ElementName = "Item")]
        public List<KitItem> Items;
        public int Cooldown = 0;
    }

    public class KitItem{

        public KitItem(){ }

        public KitItem(ushort itemId, byte amount)
        {
            ItemId = itemId;
            Amount = amount;
        }

        [XmlAttribute("id")]
        public ushort ItemId;

        [XmlAttribute("amount")]
        public byte Amount;
    }
}
