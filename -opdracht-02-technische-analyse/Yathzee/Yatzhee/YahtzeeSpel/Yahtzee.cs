using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeSpel
{
  public class Yahtzee
  {
    private Teerling[] teerlingen;
    private int aantalWorpen;
    private List<YahtzeeUI> observersList = new List<YahtzeeUI>();


    public const int MAX_AANTAL_WORPEN = 3;
    public const int AANTAL_TEERLINGEN = 3;
    
    public Yahtzee()
    {
      teerlingen = new Teerling[AANTAL_TEERLINGEN];
      
    }

    public bool isFinished()
    {
      return aantalWorpen == MAX_AANTAL_WORPEN;

    }

    public int getAantalWorpen
    {
      get { return aantalWorpen; }

    }

    public void getScore()
    {
    }

    public Teerling getTeerling(int index)
    {

        //NEEDS TO CHANGE
        
    }


    public void werp()
    {
    }

    public void reset()
    {
    }

  
    public void addObserver(YahtzeeUI observer)
    {
      observersList.Add(observer);
    }
    private void notifyObservers()
    {
      foreach (YahtzeeUI y in observersList)
      {
        y.updateUI();
      }

    }
  }
}
