using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yp02.Classes
{
    public class Partners
    {
        public int Id { get; set; }
        public int IdType { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long INN { get; set; }
        public string FIO { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
        public int Rating { get; set; }

        public Partners(int id, int idType, string name, string address, long inn, string fio, long phone,string email,int rating) { 
        this.Id = id;
            this.IdType = idType;
            this.Name = name;
            this.Address = address;
            this.INN = inn;
            this.FIO = fio;
            this.Phone = phone;
            this.Email = email;
            this.Rating = rating;
        }
    }
}
