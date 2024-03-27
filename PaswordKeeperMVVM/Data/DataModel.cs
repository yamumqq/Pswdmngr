﻿using System;
using System.Data.Entity;
using System.Linq;
using PaswordKeeperMVVM.Models;

namespace PaswordKeeperMVVM.Data
{
    public class DataModel : DbContext
    {
        // Контекст настроен для использования строки подключения "DataModel" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "PaswordKeeperMVVM.Data.DataModel" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataModel" 
        // в файле конфигурации приложения.
        public DataModel()
            : base("name=DataModel")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Category> Categories { get; set; }
         public virtual DbSet<MyNote> MyNotes { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}