﻿namespace PhotoShare.Client
{
    using Core;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Linq;

    public class Application
    {
        public static void Main()
        {
            ResetDatabase();
            CommandDispatcher commandDispatcher = new CommandDispatcher();
            Engine engine = new Engine(commandDispatcher);
            engine.Run();
        }

        private static void ResetDatabase()
        {
            using (var db = new PhotoShareContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}