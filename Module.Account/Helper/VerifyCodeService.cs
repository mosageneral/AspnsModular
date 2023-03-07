using BL.Infrastructure;
using Microsoft.Extensions.Options;
using Module.Account.BL.Security;
using Module.Account.DL.Entities.UserEntities;

namespace Module.Account.Helper
{
    internal interface IVerifyCodeService
    {
        public bool SendOTP(string MobileNum, Guid userId);

        public bool ActivateOTP(int VerfiyCode);

        public bool ForgetPasswordOTP(int VerfiyCode);
    }

    internal class VerifyCodeService : IVerifyCodeService
    {
        private readonly IUnitOfWork _uow;
        public readonly ISMS _SMS;
        private readonly VariableConfig _tokenManagement;

        public VerifyCodeService(IUnitOfWork uow, ISMS SMS, IOptions<VariableConfig> tokenManagement)
        {
            _uow = uow;
            _SMS = SMS;
            _tokenManagement = tokenManagement.Value;
        }

        public bool ActivateOTP(int VerfiyCode)
        {
            var Entity = _uow.VerfiyCodeRepository.GetMany(a => a.VirfeyCode == VerfiyCode).FirstOrDefault();
            if (Entity != null)
            {
                if (Entity.Date < DateTime.Now)
                {
                    return false;
                }
                var User = _uow.UserRepository.GetById(Entity.UserId);
                User.IsActive = true;
                _uow.UserRepository.Update(User);
                _uow.VerfiyCodeRepository.Delete(Entity.Id);

                _uow.Save();

                return true;
            }
            return false;
        }

        public bool ForgetPasswordOTP(int VerfiyCode)
        {
            var Entity = _uow.VerfiyCodeRepository.GetMany(a => a.VirfeyCode == VerfiyCode).FirstOrDefault();
            if (Entity != null)
            {
                if (Entity.Date < DateTime.Now)
                {
                    return false;
                }

                _uow.VerfiyCodeRepository.Delete(Entity.Id);
                _uow.Save();

                return true;
            }
            return false;
        }

        public bool SendOTP(string MobileNum, Guid userId)
        {
            if (MobileNum != null && userId != null)
            {
                int num = new Random().Next(1000, 9999);
                var VC = new VerfiyCode { Date = DateTime.Now.AddMinutes(5), PhoneNumber = MobileNum, UserId = userId, VirfeyCode = num };
                _uow.VerfiyCodeRepository.Add(VC);
                _uow.Save();
                var Message = string.Format("Use This OTP Code {0}\n " + "كود التحقق  {1}", num.ToString(), num.ToString());
                var s = _SMS.SendSMS(MobileNum, Message);

                return true;
            }
            return false;
        }
    }
}