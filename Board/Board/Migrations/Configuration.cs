namespace Board.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity.Owin;
    using Board.Models;


        

    internal sealed class Configuration : DbMigrationsConfiguration<Board.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Board.Models.ApplicationDbContext";
        }

        protected override void Seed(Board.Models.ApplicationDbContext context)
        {
           
            AddUser(context);
        }
        // Создаем метод,который будет работать при создании бд
        public void AddUser(Board.Models.ApplicationDbContext context)
        {
            //Создаем пользователя
            var user = new ApplicationUser { UserName = "test@gmail.com" };
            var ums = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            ums.Create(user, "password");

        }
    }
}
