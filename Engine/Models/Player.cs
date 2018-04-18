using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Player : INotifyPropertyChanged
    {
        private int _experincePoints;
        private string _name;
        private string _charcterClass;
        private int _level;
        private int _gold;
        private int _hitPoints;

        public string Name
        {
            get { return _name; }
            set { _name = value;
                OnPropertyChanged("Name");
            }
        }


        public string CharacterClass
        {
            get { return _charcterClass; }
            set { _charcterClass = value;
                OnPropertyChanged("CharacterClass");
            }
        }

       

        public int HitPoints
        {
            get { return _hitPoints; }
            set { _hitPoints = value;
                OnPropertyChanged("HitPoints");
            }
        }



        public int ExperincePoints
        {
            get { return _experincePoints; }
            set
            {
                _experincePoints = value;
                OnPropertyChanged("ExperincePoints");
            }
        }


        public int Level
        {
            get { return _level; }
            set { _level = value;
                OnPropertyChanged("Level");
            }
        }


        public int Gold
        {
            get { return _gold; }
            set { _gold = value;
                OnPropertyChanged("Gold");

            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
