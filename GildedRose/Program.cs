using System;
using System.Collections.Generic;
using System.IO;

namespace GildedRose
{
    //Kata => http://codingdojo.org/kata/GildedRose/
    public class Program
    {
        private static Stream stream;
        public static void Main(string[] args)
        {
            try
            {

                Initializer();

                Console.WriteLine("OMGHAI!");

                IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

                var app = new GildedRose(Items);


                Rapport<Item> rapport = new Rapport<Item>();
                string header = "Name, SellIn, Quality";
                for (var i = 0; i < 31; i++)
                {

                    Console.WriteLine("-------- day " + i + " --------");
                    Console.WriteLine(header);
                    List<Item> items = new List<Item>();
                    for (var j = 0; j < Items.Count; j++)
                    {
                        Item item = cloneItem(Items[j]);
                        System.Console.WriteLine(RapportDataFormatter.Stringifyer(item));
                        items.Add(item);
                    }
                    RapportSection<Item> sectionDuJour = rapport.CreateSection(i, items);
                    rapport.AjouterSection(sectionDuJour);

                    Console.WriteLine("");
                    app.UpdateQuality();
                }

                /*
                 * presentation du rapport
                 *
                 */
                string path = @"output.txt";
                IGenerator generator = new FileStringRapportGenerator<Item>(path);
                generator.GenerateRapport(rapport);


            }
            finally
            {
                CleanUp();
            }

        }

        private static void CleanUp()
        {
            stream.Dispose();
        }

        private static void Initializer()
        {
            stream = new FileStream("GoldenMaster.txt", FileMode.OpenOrCreate  );
            TextWriter textWriter = new StreamWriter(stream);
            Console.SetOut(textWriter);
        }

        private static Item cloneItem(Item item)
        {
            return new Item()
            {
                Name = item.Name,
                Quality = item.Quality,
                SellIn = item.SellIn
            };
        }
    }
}
