using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoto
{
    enum Color
    {
        WHITE,
        BLACK,
        RED,
        GREEN,
        BLUE,
    }

    enum Country
    {
        NO_COUNTRY,
        JAPAN,
        USA,
        ITALY,
    }

    partial class Moto
    {
        // конструкторы
        public Moto(string mark, string model, Color color, int maxSpeed, int curSpeed, Country country)
        {
            ++_count;
            _id = _count;
            _mark = mark;
            _model = model;
            _bodyColor = color;
            _maxSpeed = maxSpeed;
            _curSpeed = curSpeed;
            _make = country;

        }
        public Moto() : this("", "", Color.WHITE, 200, 0, Country.NO_COUNTRY) { }
        public Moto(string mark, Country country) : this(mark, "", Color.WHITE, 200, 0, country) { }
        public Moto(string mark, string model, Country country) : this(mark, model, Color.WHITE, 200, 0, country) { }
        static Moto()
        {
            _count = 0;
            _makers = new string[] {"не указан",
                                    "Япония",
                                    "США",
                                    "Италия"};

            _colors = new string[] {"белый",
                                    "черный",
                                    "крысный",
                                    "зеленый",
                                    "синий"};

        }

        // сеттеры
        public void setMark(ref string mark)
        {
            _mark = mark;
        }
        public void setModel(ref string model)
        {
            _model = model;
        }
        public void setColor(Color color)
        {
            _bodyColor = color;
        }
        public void setMaxSpeed(int speed)
        {
            _maxSpeed = speed;
        }
        public void setMaker(Country country)
        {
            _make = country;
        }

        // геттеры
        public string getMark()
        {
            return _mark;
        }
        public string getModel()
        {
            return _model;
        }
        public Color getColor()
        {
            return _bodyColor;
        }
        public int getMaxSpeed()
        {
            return _maxSpeed;
        }
        public int getCurSpeed()
        {
            return _curSpeed;
        }
        public Country getMaker()
        {
            return _make;
        }
        public int getId()
        {
            return _id;
        }
        public int getOdometr()
        {
            return _odometr;
        }


        // методы
        public override string ToString()
        {
            return $"Id: {_id}\n" +
                   $"Марка: {_mark}\n" +
                   $"Модель: {_model}\n" +
                   $"Страна - производитель: {_makers[(int)_make]}\n" +
                   $"Максимальная скорость: {_maxSpeed} км/ч\n" +
                   $"Цвет: {_colors[(int)_bodyColor]}\n" +
                   $"Пробег: {_odometr}\n";
        }
        
        // поля
        private static string[] _makers;  // массив производителей
        private static string[] _colors;  // массив цветов
        private static int _count;        // счетчик созданных объектов
        private int _id;                  // номер мотоцикла
        private string _mark;
        private string _model;
        private Color _bodyColor;
        private int _maxSpeed;            
        private int _curSpeed;            // текущая скорость
        private Country _make;
        private int _odometr;              // пробег
    }

   

}
