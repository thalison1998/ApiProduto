﻿namespace ApiWeb.Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task CommitAsync();
}

