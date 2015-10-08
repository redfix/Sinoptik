﻿using Sinoptik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sinoptik.ViewModel
{
    class XSANVM
    {
        readonly XSANTest _sANTest;

        public XSANVM(XSANTest san)
        {
            _sANTest = san;
        }

        public XSANVM()
        {
            _sANTest = new XSANTest();
        }
        
        internal XSANTest SANTest
        {
            get
            {
                return _sANTest;
            }
        }

        public Int16 Feeling
        {
            get 
            {
                return SANTest.SANFeeling;
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (1-6)"); //?? или сделать это в методе с проверкой?
                else
                SANTest.SANFeeling = value;
            }
        }

        public Int16 PassivActiv
        {
            get 
            {
                return SANTest.SANPassivActiv; 
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (1-6)");
                else
                    SANTest.SANPassivActiv = value;
            }
        }

        public Int16 Mood 
        {
            get 
            {
                return SANTest.SANMood;
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (1-6)");
                else
                    SANTest.SANMood = value;
            }
        }

        public Int16 FullForceExhausted
        {
            get 
            {
                return SANTest.SANFullForceExhausted;
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (1-6)");
                else
                    SANTest.SANFullForceExhausted = value;
            }
        }

        public Int16 RestedTired
        {
            get 
            {
                return SANTest.SANRestedTired;
            }
            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (1-6)");
                else
                    SANTest.SANRestedTired = value;
            }
        }

        public Int16 SlepyHorny
        {
            get 
            {
                return SANTest.SANSlepyHorny;
             }

            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (1-6)");
                else
                    SANTest.SANSlepyHorny = value;
            }
        }

        public Int16 DesireToWork
        {
            get
            {
               return SANTest.SANDesireToWork;
            }

            set
            {
                if (!Validation(value))
                    throw new ArgumentException("Значение вне пределов допустимого диапозона (1-6)");
                else
                    SANTest.SANDesireToWork = value;
            }
        }


        private Boolean Validation(Int16 value)
        {
            if (value > 6 || value < 1)
                return false;
            else
                return true;
        }

        private Int16 IntegralAssessment()
        {
            Int16 ass = 0;
            return ass;
        }
    }
}