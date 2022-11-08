namespace CourseApp.Task_1
{
    using System;

    public abstract class Weapon
    {
        private int maxAmmo;

        public string WeaponType { get; protected set; }

        public string ShootingType { get; set; }

        public string Name { get; set; }

        public int MaxAmmo
        {
            get
            {
                return maxAmmo;
            }

            set
            {
                if (value < 1)
                {
                    throw new Exception("INCORRECT MAX COUNT OF AMMO!");
                }
                else
                {
                    maxAmmo = value;
                }
            }
        }

        public int CurrentAmmo { get; protected set; }

        public abstract string Info();

        public abstract bool Shoot();

        public abstract bool Reload();
    }
}