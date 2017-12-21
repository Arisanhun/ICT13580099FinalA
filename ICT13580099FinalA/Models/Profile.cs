using System;
namespace ICT13580099FinalA.Models
{
    public class Profile
    {
        public Profile()
        {
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        internal int Insert(Profile profile)

        {
            throw new NotImplementedException();
        }
        public string Sender { get; set; }

        public string Work { get; set; }

        public string Phone { get; set; }

        public string Email
        {
            get;
            set;
        }
        public String Address
        {
            get;
            set;
        }
		public String Status
		{
			get;
			set;
		}
		public int Num
		{
			get;
			set;
		}
		
		public String Salary
		{
			get;
			set;
		}
    }
}




