namespace HouseFunction
{
    public class House
    {
        // private will make this field belong to only this c# doc
        private string owner;
        private string ghost;
        private int roomCount; 

        public House()
        {
            owner = "Nathan";
            ghost = "King Boo";
            roomCount = 1;
        }  
        public string Owner { get{return owner;} set{owner = value;} }
        public string MiceName { get; set; }

    }
}