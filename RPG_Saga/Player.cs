namespace RpgSaga
{
    public abstract class Player
    {
        private IAbility _ability;
        private string _name;
        private int health;
        private int strength;

        public string Name
        {
            get 
            {
                return _name;
            }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
            }
        }

        public IAbility Ability
        {
            get
            {
                return _ability;
            }
            set
            {
                _ability = value;
            }
        }

        public void Attack()
        {
            return;
        }

        public void PerformAbility()
        {
            Ability.UseAbility();
        }
    } 
}
