// <copyright file="AuthenticationServices.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CoffeeManagementSystem.Services.AuthenticationServices
{
    using System.Collections.Generic;
    using AutoMapper;
    using CoffeeManagementSystem.Data.EntityContext;
    using CoffeeManagementSystem.Model.EntitiesModel;
    using CoffeeManagementSystem.Model.Model;

    public class AuthenticationServices : BaseServices.BaseServices, IAuthenticationServices
    {
        #region Contructor, Varible

        private readonly IMapper _mapper;
        public AuthenticationServices(IMapper mapper)
        {
            _mapper = mapper;
            Context = new CoffeeManagementSystemContext();
        }

        #endregion

        #region GetListGroupUser DONE
        /// <summary>
        /// Hàm Get ListGroup User.
        /// </summary>
        /// <returns>Danh sách nhóm người dùng.</returns>
        public List<GroupUserModel> GetListGroupUser()
        {
            var resultData = GetList<GroupUserEntities>(guser => guser.Status == Model.Enum.StatusSystem.Active);
            return _mapper.Map<List<GroupUserModel>>(resultData);
        }
        #endregion

        #region GetListRoleUserOfGroupUser
        public List<RoleModel> GetListRoleUserOfGroupUser()
        {
            var resultData = GetList<RoleEntities>(r => r.Status == Model.Enum.StatusSystem.Active);
            return _mapper.Map<List<RoleModel>>(resultData);
        }
        #endregion

        #region InsertListRuleForGroupUser
        public bool InsertListRuleForGroupUser(List<CredentialUserModel> credentialUserModel, int userId)
        {
            for (var indexRequest = 0; indexRequest < credentialUserModel.Count; indexRequest++)
            {
                credentialUserModel[indexRequest].CreateBy = userId;
                credentialUserModel[indexRequest].UpdateBy = userId;
                credentialUserModel[indexRequest].Status =  Model.Enum.StatusSystem.Active;
            }
            return BulkInsertExcel(_mapper.Map<List<CredentialUserEntities>>(credentialUserModel));
        }
        #endregion

        #region UpdateGroupUserForUser
        public bool UpdateGroupUserForUser(int userId, int groupUserId)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
