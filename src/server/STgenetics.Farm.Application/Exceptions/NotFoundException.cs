﻿
namespace STgenetics.Farm.Application.Exceptions
{
    using System;
    public class NotFoundException : Exception
    {
        public NotFoundException(string name, object key) : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }

        public NotFoundException(string message) : base(message)
        {

        }
    }
}