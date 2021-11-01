using Models;

namespace userInterface
{
        public class SingletonUser
        {
                public static Users users = new Users();
                public static Orders orders = new Orders();
                public static string location { get; set; }  
                     
        }
    }