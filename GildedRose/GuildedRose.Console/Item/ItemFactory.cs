using System;
using System.Collections.Generic;
using System.Reflection;

namespace GuildedRose.Console.Item
{
    public static class ItemFactory
    {
        //private Dictionary<string, Type> _itemTypesDictionary;
        //private Item _Item;

        public static ItemBase CreateDecoratedItem(Item itemToDecorate)
        {
            ItemBase item = new ItemRegular(itemToDecorate);

            switch (itemToDecorate.Name)
            {
                case "Sulfuras, Hand of Ragnaros":
                    item = new LegendaryDecoration(item);
                    break;

                case "Aged Brie":
                    item = new AgedBrieDecoration(item);
                    break;

                case "Backstage passes to a TAFKAL80ETC concert":
                    item = new BackstageDecoration(item);
                    break;

                case "Conjured Mana Sword":
                    item = new ConjuredDecoration(item);
                    break;

            }
            return item;
        }

        

        //public ItemFactory(Item itemToDecorate)
        //{
        //    _Item = itemToDecorate;
        //    LoadTypesICanReturn();
        //}

        //public ItemBase CreateInstance(string itemName)
        //{
        //    Type t = GetTypeToCreate(itemName.Replace(" ", string.Empty).ToLower());

        //    if (t == null)
        //        return new ItemRegular(_Item);


        //    //Type[] ArgumentType = new[] { Type.GetType("Item") };
        //    //ConstructorInfo Constructor = t.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance |
        //    //    BindingFlags.Public, null, new Type[] { typeof(Item) }, null);
        //    //ItemBase obj = (ItemBase)  Constructor.Invoke(new object[] {_Item}) ;
        //    //return obj;

        //    return (ItemBase)Activator.CreateInstance(t, BindingFlags.NonPublic | BindingFlags.Instance |
        //        BindingFlags.Public, BindingFlags.FlattenHierarchy, new Type[] { typeof(Item) }) as ItemBase;

        //    //return (ItemBase)Activator.CreateInstance(t, BindingFlags.NonPublic | BindingFlags.Instance |
        //       //BindingFlags.Public, _Item) as ItemBase;


        //}

        //Type GetTypeToCreate(string itemName)
        //{
        //    foreach (var item in _itemTypesDictionary)
        //    {
        //        if (item.Key.Contains(itemName))
        //        {
        //            return _itemTypesDictionary[item.Key];
        //        }
        //    }

        //    return null;
        //}

        //void LoadTypesICanReturn()
        //{
        //    _itemTypesDictionary = new Dictionary<string, Type>();

        //    Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

        //    foreach (Type type in typesInThisAssembly)
        //    {
        //        if (type.GetInterface(typeof(IItemBase).ToString()) != null)
        //        {
        //            _itemTypesDictionary.Add(type.Name.ToLower(), type);
        //        }
        //    }
        //}

    }
}