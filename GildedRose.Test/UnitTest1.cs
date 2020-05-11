using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using GildedRose;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace GildedRose.Test
{
    [TestClass]
    public class UnitTest1
    {
        string headerItem = "Name, SellIn, Quality"; 
        [TestMethod]
        public void ShouldCreateEmptyRapport()
        {
            Rapport<Item> rapport = new Rapport<Item>();
            int jourDuRapport = 1;
            RapportSection<Item> section = rapport.CreateSection(jourDuRapport, new List<Item>() );

            rapport.AjouterSection(section);

            Assert.AreEqual(headerItem, section.GetHeader());
            Assert.AreEqual(jourDuRapport, section.JourDuRapport);
        }

        IList<Item> Items = new List<Item>{
            new ItemCommon() {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
            new ItemCommon {Name = "Aged Brie", SellIn = 2, Quality = 0},
            new ItemCommon {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
            new ItemCommon {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
            new ItemCommon {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
            new ItemCommon {Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20},
            new ItemCommon {Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 10,Quality = 49},
            new ItemCommon {Name = "Backstage passes to a TAFKAL80ETC concert",SellIn = 5,Quality = 49},
            new ItemCommon {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
        };

        [TestMethod]
        public void ShouldCreateRapportWithOneSection()
        {
            Rapport<Item> rapport = new Rapport<Item>();
            RapportSection<Item> section = rapport.CreateSection(0, new List<Item>(Items));
            rapport.AjouterSection(section);
        }

        [TestMethod]
        public void ShouldGenerateRapportWithOneSection()
        {
            Rapport<Item> rapport = new Rapport<Item>();
            RapportSection<Item> section = rapport.CreateSection(0, new List<Item>(Items));
            rapport.AjouterSection(section);

            string path = @"output.txt";
            IGenerator generator = new FileStringRapportGenerator<Item>(path);
            generator.GenerateRapport(rapport);

        }
    }
}
