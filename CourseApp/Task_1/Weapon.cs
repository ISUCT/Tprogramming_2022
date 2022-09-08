namespace CourseApp
{
    using System;

    public abstract class Weapon
    {
        private int _maxAmmo;

        public string WeaponType { get; protected set; }

        public string ShootingType { get; set; }

        public string Name { get; set; }

        public int MaxAmmo
        {
            get
            {
                return _maxAmmo;
            }

            set
            {
                if (value < 1)
                {
                    throw new Exception("INCORRECT MAX COUNT OF AMMO!");
                }
                else
                {
                    _maxAmmo = value;
                }
            }
        }

        public int CurrentAmmo { get; protected set; }

        public abstract void Info();

        public abstract void Shoot();

        public abstract void Reload();
    }
}