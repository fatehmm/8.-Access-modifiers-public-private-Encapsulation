using System;
namespace Homework01062022
{
	public class User
	{
		public User(string pw)
		{
            UserName = pw;
		}
		private string _userName;
		private string _password;

		public string UserName
        {
            get
            {
				return _userName;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value .Length>= 6 && value.Length<=25 )
                {
                    _userName = value;
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 8 && value.Length <= 25)
                {
                    bool checkPasswordDigit = HasDigit(value);
                    bool checkPasswordLower = HasLower(value);
                    bool checkPasswordUpper = HasUpper(value);

                    if (checkPasswordDigit == true && checkPasswordLower == true && checkPasswordUpper == true)
                    {

                        _password = value;
                    }

                }
            }
        }

        public bool HasDigit(string word)
        {
            bool checkPasswordDigit = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]) == true)
                {
                    checkPasswordDigit = true;
                    break;
                }
                else
                {
                    checkPasswordDigit = false;
                }
            };
            return checkPasswordDigit;
        }

        public bool HasUpper(string word)
        {
            bool checkUpper = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i]) == true)
                {
                    checkUpper = true;
                    break;
                }
                else
                {
                    checkUpper = false;
                }
            };
            return checkUpper;
        }

        public bool HasLower(string word)
        {
            bool checkLower = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]) == true)
                {
                    checkLower = true;
                    break;
                }
                else
                {
                    checkLower = false;
                }
            };
            return checkLower;
        }
    }
}

