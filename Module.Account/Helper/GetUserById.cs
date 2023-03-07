using BL.Infrastructure;
using Shared.Models.Interfaces;

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