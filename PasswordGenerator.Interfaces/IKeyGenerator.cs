using System;

namespace PasswordGenerator.Interfaces
{
    public interface IKeyGenerator
    {
        int Length { get; set; }
        string Password { get; set; }

        void Generate();
    }
}
