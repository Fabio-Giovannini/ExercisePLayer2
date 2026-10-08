namespace BlaisePascal.ExercisePlayer.Domain
{
    public class Player
    {
        private string _name;
        private int _level;
        private int _experience;
        private int _health;
        private int _maxHealth;
        private bool _isAlieve;
        private int _gold;

        //creation of properties
        public string Name
        {
            get { return _name; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }

                _name = value;
            }
        }

        public int Level
        {
            get { return _level; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Level must be greater than or equal to 1.");
                }
                _level = value;
            }
        }

        public int Experience
        {
            get { return _experience; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Experience must be greater ot equal to 0.");
                }
                _experience = value;
            }
        }

        public int Health
        {
            get { return _health; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Health must be greater than or equal to 0.");
                }
                _health = value;
            }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("MaxHEalth must be greater or equal to 1");
                }
                _maxHealth = value;
            }
        }

        public bool IsAlive
        {
            get { return _isAlieve; }
            private set { _isAlieve = value; }
        }

        public int Gold
        {
            get { return _gold; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Gold must be greater than or equal to 0.");
                }
                _gold = value;
            }
        }

        //constructor definition
        public Player(string name)
        {
            Name = name;
            Experience = 0;
            Level = 1;
            MaxHealth = 100;
            Health = MaxHealth;
            IsAlive = true;
            Gold = 0;
        }

        //method for increasing experience points
        public void AddExperience(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be greater or equal to 0");
            }

            Experience += amount;

            while (Experience >= 100)
            {
                Experience -= 100;
                Level += 1;
            }
        }

        //method for reset experience
        public void ResetExperience()
        {
            Experience = 0;
        }

        //method for taking damage
        public void TakeDamage(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Damage amount must be a positive integer.");
            }

            if (amount < Health)
            {
                Health -= amount;
            }
            else
            {
                Health = 0;
                IsAlive = false;
            }
        }

        //method for healing
        public void Heal(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Healing amount must be a positive integer.");
            }

            Health += amount;

            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        //method for increase gold
        public void AddGOld(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be greater or equal to 0.");
            }

            Gold += amount;
        }

        //method for reset health
        public void ResetHealth()
        {
            Health = MaxHealth;
            IsAlive = true;

        }
    }
}
