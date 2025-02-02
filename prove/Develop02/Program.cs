using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        bool _loop = true;

        Journal _newJournal = new Journal();

        while (_loop == true)
        {
            int _userChoice = _newJournal.Menu();

            switch (_userChoice)
            {
                case 1:

                    _newJournal.WriteNewEvent();
                    break;

                case 2:
                    _newJournal.Display();
                    break;

                case 3:
                    _newJournal.Load();
                    break;

                case 4:
                    _newJournal.Save();
                    break;

                case 5:
                    _loop = false;
                    break;


            }
        }


    }

}