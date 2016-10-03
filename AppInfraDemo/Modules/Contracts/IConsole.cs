﻿namespace Contracts
{
    public interface IConsole
    {
        string AskInput(string message);
        void WriteEntity<T>(T salesOrderInfo);
        void WriteLine(string line);
    }
}