using System;

namespace Sinoptik.ViewModel
{
    abstract class XParameterBase<TValue> where TValue : IComparable<TValue>
    {
        static String _name;
        static TValue _maxValidValue;
        static TValue _minValidValue;
        static TValue _maxAllowableValue;
        static TValue _minAllowableValue;
        static TValue _maxDangerouseValue;
        static TValue _minDangerouseValue;
        static String _measure;
        TValue _value;


        static public string Name
        {
            get
            {
                return _name;
            }
            protected set
            {
                _name = value;
            }
        }

        public TValue Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public static TValue MaxValidValue
        {
            get
            {
                return _maxValidValue;
            }
            protected set
            {
                _maxValidValue = value;
            }
        }

        public static TValue MinValidValue
        {
            get
            {
                return _minValidValue;
            }
            protected set 
            {
                _minValidValue = value;
            }
        }

        public static TValue MaxAllowableValue
        {
            get
            {
                return _maxAllowableValue;
            }
            protected set
            {
                _maxAllowableValue = value;
            }
        }

        public static TValue MinAllowableValue
        {
            get
            {
                return _minAllowableValue;
            }
            protected set
            {
                _minAllowableValue = value;
            }
        }

        public static TValue MaxDangerouseValue
        {
            get
            {
                return _maxDangerouseValue;
            }
            protected set
            {
                _maxDangerouseValue = value;
            }
        }

        public static TValue MinDangerouseValue
        {
            get
            {
                return _minDangerouseValue;
            }
            protected set
            {
                _minDangerouseValue = value;
            }
        }

        public static string Measure
        {
            get
            {
                return _measure;
            }
            protected set
            {
                _measure = value;
            }
        }

        /// <summary>
        /// Проверяет лежит ли значение параметра в допустимых пределах
        /// </summary>
        /// <returns></returns>
        public Boolean IsAllowable() 
        {
            if (Value.CompareTo(MinAllowableValue) > 0 || Value.CompareTo(MaxAllowableValue) < 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверяет лежит ли значение параметра в опасных пределах
        /// </summary>
        /// <returns></returns>
        public Boolean IsDangerous()
        {
            if (!IsAllowable() && !IsExtrem())
                return true;
            else
                return false;
        }

        /// <summary>
        /// Проверяет выходит ли значение параметра за опасные границы
        /// </summary>
        /// <returns></returns>
        public Boolean IsExtrem()
        {
            if (Value.CompareTo(MinDangerouseValue) < 0 || Value.CompareTo(MaxDangerouseValue) > 0)
                return true;
            else
                return false;
        }

        
    }
}
