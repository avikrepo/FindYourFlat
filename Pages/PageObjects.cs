namespace TestProject2.Pages
{
    public class PageObjects
    {
        public static HomePage home;
        public static HomePage homePage { 
            get { 
                if (home != null) 
                    return home; 
                else return new HomePage(); 
            } 
            set { 
                home = new HomePage(); 
            } 
        }


    }
}
