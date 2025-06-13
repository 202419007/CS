using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
#if TWO
    class Animal
    {
        private string _name;
        private int _level;
        protected COLOR _color;

        public string Name
        {
            get { return _name; }
        }

        public COLOR Color
        {
            get { return _color; }
        }

        public int Level
        {
            get { return _level; }
        }

        public Animal(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        public override string ToString()
        {
            return $"ANIMAL:{_name}";
        }

        public void Eat()
        {
            AddLevel(3);
        }

        public void Play()
        {
            AddLevel(2);
        }

        protected bool AddLevel(int level)
        {
            if (_level + level <= 100) {
                _level += level;
                return true;
            } else {
                return false;
            }
        }
    }
#elif THREE
    class Animal
    {
        private string _name;
        private int _level;
        protected COLOR _color;

        public string Name
        {
            get { return _name; }
        }

        public COLOR Color
        {
            get { return _color; }
        }

        public int Level
        {
            get { return _level; }
        }

        public Animal(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        public override string ToString()
        {
            return $"ANIMAL:{_name}";
        }

        public virtual void Eat()
        {
            AddLevel(3);
        }

        public void Play()
        {
            AddLevel(2);
        }

        protected bool AddLevel(int level)
        {
            if (_level + level <= 100) {
                _level += level;
                return true;
            } else {
                return false;
            }
        }
    }
#elif FOUR
    abstract class Animal
    {
        private string _name;
        protected int _level;
        protected COLOR _color;

        public string Name
        {
            get { return _name; }
        }

        public COLOR Color
        {
            get { return _color; }
        }

        public int Level
        {
            get { return _level; }
        }

        public Animal(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        public override string ToString()
        {
            return $"ANIMAL:{_name}";
        }

        public virtual void Eat()
        {
            AddLevel(3);
        }

        public void Play()
        {
            AddLevel(2);
        }

        abstract protected bool AddLevel(int level);
        //{
        //    if (_level + level <= 100) {
        //        _level += level;
        //        return true;
        //    } else {
        //        return false;
        //    }
        //}
    }
#endif
    abstract class Animal : Object
    {
        private string _name;
        protected int _level;
        protected COLOR _color;

        public string Name { get { return _name; } }
        public int Level { get { return _level; } }
        public COLOR Color { get { return _color; } }

        public Animal(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        //Object 클래스의 ToString()을
        //override(재정의)한다.
        public override string ToString()
        {
            return $"ANIMAL:{_name}";
        }

        public virtual void Eat()
        {
            AddLevel(3);
        }

        public void Play()
        {
            AddLevel(2);
        }

        abstract protected bool AddLevel(int level);

    }
}
