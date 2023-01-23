
using BL.Repositories;
using System;

namespace BL.Infrastructure
{
    internal interface IUnitOfWork : IDisposable
    {


        ProductRepository ProductRepository { get; }
        CategoryRepository CategoryRepository { get; }
        SubCategoryRepository SubCategoryRepository { get; }
        MakeRepository MakeRepository { get; }
        ModelRepository ModelRepository { get; }
        YearRepository YearRepository { get; }



        int Save();
      
    }
}
