using System.Collections.Generic;

    static class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            IList<Item> items = new List<Item> {
                new Item {
                    Name = "+5 Dexterity Vest",
                    SellIn = 10,
                    Quality = 20
                },
                new Item {
                    Name = "Aged Brie",
                    SellIn = 2,
                    Quality = 0
                },
                new Item {
                    Name = "Elixir of the Mongoose",
                    SellIn = 5,
                    Quality = 7
                },
                new Item {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = 0,
                    Quality = 80
                },
                new Item {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item {
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 6
                }
            };


            var guildedRose = new GildedRose(items);  
               
            for (int i = 0; i < 31; i++)
            {
                System.Console.WriteLine("-------- jour       " + i + " --------");
                System.Console.WriteLine("name, sellIn, quality");
                for (int j = 0; j < items.Count; j++)
                {
                    System.Console.WriteLine(items[j].Name + ", " + items[j].SellIn + ", " + items[j].Quality);
                }
                System.Console.WriteLine("");
                guildedRose.UpdateQuality();
                System.Console.ReadKey();
            }
            System.Console.ReadKey();
        }

    }


