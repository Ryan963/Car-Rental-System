






namespace _291_Project
{


    public class Branch
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string street_number { get; set; }
        public string city { get; set; }
        public string Zip { get; set; }
        public string provence { get; set; }
        public string country { get; set; }
        public string phone_number { get; set; }

        


        public string branch
        {
            get
            {
            return $"{Name}";
            }
        }

        public string FullInfo
        {
            get
            {
            return $"{ID}, {Name}, {street_number}, {city}, {Zip}, {provence}, {country}, {phone_number}";
            }
        }
    }
}



