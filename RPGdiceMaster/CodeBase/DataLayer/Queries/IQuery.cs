﻿namespace RPGdiceMaster.CodeBase.DataLayer.Queries
{
    public interface IQuery<T>
    {
        T Execute();
    }
}