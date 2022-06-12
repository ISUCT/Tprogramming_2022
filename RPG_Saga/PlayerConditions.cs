namespace RpgSaga
{
    public class PlayerConditions
    {
        public Dictionary<Conditions, bool> Condition;

        public PlayerConditions()
        {
            Condition = new Dictionary<Conditions, bool>();
            FillConditionsDictionary();
        }

        private void FillConditionsDictionary()
        {
            var conditions = Enum.GetValues(typeof(Conditions));
            foreach(Conditions condition in conditions)
            {
                Condition.Add(condition, false);
            }
        }
    }
}
