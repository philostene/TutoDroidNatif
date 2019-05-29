using System;
using System.Collections.Generic;
using System.Linq;

namespace FormationHulk.Droid.Activities
{
    public static class UserData
    {
        public static List<User> Users { get; private set; }

        static UserData()
        {
            var temp = new List<User>();

            AddUser(temp);
            AddUser(temp);
            AddUser(temp);

            Users = temp.OrderBy(i => i.Name).ToList();
        }

        static void AddUser(List<User> users)
        {
            users.Add(new User()
            {
                Name = "aVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });

            users.Add(new User()
            {
                Name = "bVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
            users.Add(new User()
            {
                Name = "bVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });

            users.Add(new User()
            {
                Name = "aVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image2.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            }); users.Add(new User()
            {
                Name = "dVirendra Thakur",
                Department = "Xamarin Android & Xamarin Forms Development",
                ImageUrl = "images/image.png",
                Details = "Virndra has over 2 years of experience developing mobile applications; specializing in Android & C# cross platform development."

            });
        }
    }
}