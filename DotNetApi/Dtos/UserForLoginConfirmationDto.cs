﻿namespace DotNetApi.Dtos
{
   public partial class UserForLoginConfirmationDto
    {
        //equivalent to VarBinary
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
         public UserForLoginConfirmationDto()
        {
            if (PasswordHash == null)
            {
                PasswordHash = new byte[0];
            }
            if (PasswordSalt == null)
            {
                PasswordSalt = new byte[0];
            }
        }
    }
}
