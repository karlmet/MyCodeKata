using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildedRose.Console.Item
{
  public abstract class ItemDecorator : ItemBase
    {
      public ItemDecorator(ItemBase itemToDecorate)
      {
           Item = itemToDecorate.Item;
        }


        //public ItemDecorator( )
        //{
        // //
        //}

    }
}
