namespace CourseApp
{
    using System;

    public class AndroidPhone: SmartPhone
    {        
        public AndroidPhone() : base("+70000000", "Pixel", 2022)
        {
        }

        public AndroidPhone(string number, string name, int diagonal) : base(number, name, diagonal)
        {
        }

        public virtual void InstallApp(IAndroidApp app) 
        {
            base.InstallApp(app);
        }
    }
}