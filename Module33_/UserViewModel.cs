using System;
using System.Net.Mail;

namespace Module33_
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public bool FromRussia { get; set; }

        public UserViewModel(User user)
        {
            Id = user.Id;
            FullName = GetFullName(user.FirstName, user.LastName);
            FromRussia = IsFromRussia(user.Email);
        }

        public static string GetFullName(string fName, string lName)
        {
            return String.Concat(fName, " ", lName);
        }

        public static bool IsFromRussia(string eMail)
        {
            bool answer;
            MailAddress email = new MailAddress(eMail);
            if (email.Host.Contains(".ru"))
                answer = true;
            answer = false;

            return answer;
        }
    }
}
