﻿namespace AppDev.Repository.IRepository
{
	public interface IUnitOfWork
	{
        ICategoryRepository CategoryRepository { get; }
        IBookRepository BookRepository { get; }
        void Save();
    }
}
