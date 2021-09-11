using System;

namespace Exercise123
{
    public class Person
    {
        private string _personID;

        public string PersonID
        {
            get
            {
                return _personID;
            }
            private set
            {
                _personID = value;
            }
        }

        public Person(string fornavn, string efternavn, int age) :this(fornavn, efternavn, age, null, null)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            alder = age;
            PersonID = Guid.NewGuid().ToString();
        }

        public Person(string fornavn, string efternavn, int age, Person mor, Person far)
        {
            Fornavn = fornavn;
            Efternavn = efternavn;
            alder = age;
            PersonID = Guid.NewGuid().ToString();

            if (mor != null)
            {
                Mor = mor;
            }

            if (far != null)
            {
                Far = far;
            }
        }

        private string _fornavn;

        public string Fornavn
        {
            get { return _fornavn; }
            set
            {
                if (char.IsUpper(value[0]))
                {
                    _fornavn = value;
                }
            }
        }

        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                if (char.IsUpper(value[0]))
                {
                    _efternavn = value;
                }
            }
        }

        public int alder;
        private Person _mor;
        private Person _far;

        public Person Far
        {
            get { return _far; }
            set
            {
                if (value.alder <= alder)
                {
                    throw new Exception("Alderen på din far kan ikke være mere end dig");
                }
                else
                {
                    _far = value;
                }
            }
        }

        public Person Mor
        {
            get { return _mor; }
            set
            {
                if (value.alder <= alder)
                {
                    throw new Exception("Alderen på din mor kan ikke være mere end dig");
                }
                else
                {
                    _mor = value;
                }
            }
        }
    }
}