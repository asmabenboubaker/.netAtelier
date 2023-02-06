using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.applicationCore
{
    public class Personne
    {

        public int Id { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNai { get; set; }
        public string Nom
        {
            get; set;
        }
        public string Password { get; set; }
        public string Email { get; set; }

       
        public string ConfirmPassword { get; set; }
        public Personne()
        {
                
        }

        public Personne(int id, string prenom, DateTime dateNai, string nom, string password, string email, string confirmPassword)
        {
            Id = id;
            Prenom = prenom;
            DateNai = dateNai;
            Nom = nom;
            Password = password;
            Email = email;
            ConfirmPassword = confirmPassword;
        }



        /* public bool Login  (string password,string confirmPassword)
         {
             /*
            if(this.Password== password && this.ConfirmPassword == confirmPassword) { 
             return true;}
            return false;*/
        /*return this.Password == password && this.ConfirmPassword == confirmPassword;
    }
    public bool Login(string password, string email, string confirmPassword) {
        return this.Password == password && this.ConfirmPassword == confirmPassword && this.Email==email;
    }

*/
        // najmou nbadlou les 2 methodes b methode wahda 
        public bool Login(string password, string confirmPassword, string? email = null)
        {
            if (email != null)
            {
                return this.Password == password && this.ConfirmPassword == confirmPassword && this.Email == email;
            }
            else
                return this.Password == password && this.ConfirmPassword == confirmPassword;

        }
        public virtual void GetMyType()
        {
            Console.WriteLine("je suis personne ");
        }

        public override string ToString()
        {
            return $" {Id},{Nom},{Prenom}";
        }
    }
}
