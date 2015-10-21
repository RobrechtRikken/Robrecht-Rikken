using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeSpel
{
  public class YahtzeeController
  {
     Yahtzee model;
     TeerlingController[] teerlingControllers;

    public YahtzeeController(Yahtzee y)
    {
    
    }

    public TeerlingUI getTeerlingUI(int index)
    {
      

    }

    public YahtzeeUI getYahtzeeUI()
    {
      Yahtzee view = new YahtzeeUI(model, this);
      model.addObserver(view);
      return view;

    }
     public void btnWerpClick()
    {
      model.werp();
    }

    public void btnResetClick()
    {
      model.reset();
     
    }
  }
}
