namespace CoffeeManagementSystem.Services.CustomerServices
{
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.Common;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Security.Claims;

    public class CustomerServices : BaseServices.BaseServices, ICustomerServices
    {

        private readonly IMapper _mapper;

        #region Constructors, Variables, Dispose

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminServices"/> class.
        /// IImportFileServices.
        /// </summary>
        /// <param name="mapper">mapper.</param>
        public CustomerServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }

        public bool ChangePassword(int userId, string newPassword)
        {
            throw new System.NotImplementedException();
        }

        #endregion Constructors, Variables, Dispose

        public bool CheckLoginAccount(string pToken, List<Claim> tokenList)
        {
            var returnResult = true;
            if (tokenList?.Count > 0)
            {
                var expSever = tokenList.FirstOrDefault(x => x.Type == "exp")?.Value;
                var tokenHandler = new JwtSecurityTokenHandler();
                if (tokenHandler.ReadToken(pToken) is JwtSecurityToken jwtToken)
                {
                    var expClient = jwtToken.Claims.First(claim => claim.Type == "exp").Value;
                    if (expSever == expClient)
                    {
                        returnResult = true;
                    }
                    else
                    {
                        returnResult = false;
                    }
                }
            }

            return returnResult;
        }

        public bool CheckPassworkForUser(int userId, string oldPassword)
        {
            if (userId != 0)
            {
                string oldPasswordUser = GetObject<CustomerModel>(us => us.Id == userId).Password;
                if (oldPassword.Md5() == oldPasswordUser)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public CustomerModel GetInfomationUser(int userId)
        {
            throw new System.NotImplementedException();
        }

        public bool RegisterAccount(CustomerModel customerModel)
        {
            throw new System.NotImplementedException();
        }
    }
}
