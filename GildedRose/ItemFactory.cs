using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public class ItemFactory
    {

        /*
         "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item { Name = "Aged Brie", SellIn = 2, Quality = 0 },
                new Item { Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7 },
                new Item
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                }
                Backstage passes to a TAFKAL80ETC concert
                Conjured Mana Cake
            
            */
        public ItemCommon CreateItem(string name, int quality, int sellIn)
        {
            switch (name)
            {
                case "Aged Brie":
                    return new ItemAgedBrie() {Name = name, Quality = quality, SellIn = sellIn};
                case "Sulfuras, Hand of Ragnaros":
                    return new ItemSulfuras() {Name = name, Quality = quality, SellIn = sellIn};
                case "Backstage passes to a TAFKAL80ETC concert":
                    return new ItemBackStage() {Name = name, Quality = quality, SellIn = sellIn};
            }

            return new ItemCommon() {Name = name, Quality = quality, SellIn = sellIn};
        }

    }
}

    

    
    