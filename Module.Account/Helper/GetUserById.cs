using BL.Infrastructure;
using Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Helper
{
    internal class GetUserById : IGetUserById
    {
        private readonly IUnitOfWork unitOfWork;

        public GetUserById(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public object GetUser(Guid UserId)
        {
            return unitOfWork.UserRepository.GetById(UserId);
        }
    }
}
