using BLL.Interface.Entities;
using AutoMapper;
using DAL.Interface.DTO;
using System;

namespace BLL.Mappers
{
    public static class BLLMapper
    {
        static BLLMapper()
        {
          Mapper.Initialize(cfg => { cfg.CreateMap<BankAccount, BankAccountDto>(); });
         
        }
        public static BankAccount ToBankAccount(this BankAccountDto bankAccountDto)
        {
            return Mapper.Map<BankAccountDto, BankAccount>(bankAccountDto);
        }
        public static BankAccountDto ToBankAccountDto(this BankAccount bankAccount)
        {
            return Mapper.Map<BankAccount, BankAccountDto>(bankAccount);
        }
        private static Type GetBankAccountType(string type)
        {
            if (type.Contains("Gold"))
            {
                return typeof(GoldAccount);
            }

            if (type.Contains("Platinum"))
            {
                return typeof(PlatinumAccount);
            }

            return typeof(BaseAccount);
        }
    }
}
