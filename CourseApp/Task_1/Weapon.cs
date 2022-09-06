namespace CourseApp
{
    using System;

    public abstract class Weapon
    {
        public string WeaponType { get; protected set; }

        public string ShootingType { get; set; }

        public string Name { get; set; }

        public int MaxAmmo { get; set; }

        public int CurrentAmmo { get; set; }

        public abstract void Info();

        public abstract void Shoot();

        public abstract void Reload();
    }
}