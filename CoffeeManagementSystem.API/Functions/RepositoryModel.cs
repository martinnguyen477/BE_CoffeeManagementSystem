using CoffeeManagementSystem.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CoffeeManagementSystem.API.Functions
{
    public class RepositoryModel
    {
        // int statusErrorDefault = 500;
        // int statusSuccessDefault = 200;
        private readonly string _descriptionSuccessDefault = "The request was successful.";

        private readonly string _descriptionErrPrecondition = "The 412 response indicates that those conditions were not met, so instead of carrying out the request.";

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryModel"/> class.
        /// RepositoryModel.
        /// </summary>
        public RepositoryModel()
        {
            _repositoryType = ERepositoryStatus.Success;
            Status = (int)_repositoryType;
            Description = _descriptionSuccessDefault;
            Data = new object();
        }

        /// <summary>
        /// SetSuccess.
        /// </summary>
        /// <param name="pData">pData.</param>
        /// <param name="pMessage">pMessage.</param>
        public void SetSuccess(object pData = null, string pMessage = null)
        {
            _repositoryType = ERepositoryStatus.Success;
            Status = (int)_repositoryType;
            Description = string.IsNullOrEmpty(pMessage) ? _descriptionSuccessDefault : pMessage;
            Data = pData;
        }

        /// <summary>
        /// SetNoContent.
        /// </summary>
        /// <param name="pMessage">pMessage.</param>
        public void SetNoContent(string pMessage)
        {
            _repositoryType = ERepositoryStatus.NoContent;
            Status = (int)_repositoryType;
            Description = pMessage;
        }

        /// <summary>
        /// SetError.
        /// </summary>
        /// <param name="pError">pError.</param>
        public void SetError(string pError)
        {
            _repositoryType = ERepositoryStatus.Error;
            Status = (int)_repositoryType;
            Description = pError;
        }

        /// <summary>
        /// SetNoCookie.
        /// </summary>
        /// <param name="pMessage">pMessage.</param>
        public void SetNoCookie(string pMessage)
        {
            _repositoryType = ERepositoryStatus.NoCookie;
            Status = (int)_repositoryType;
            Description = pMessage;
        }

        /// <summary>
        /// SetErrorPrecondition.
        /// </summary>
        public void SetErrorPrecondition()
        {
            _repositoryType = ERepositoryStatus.Precondition;
            Status = (int)_repositoryType;
            Description = _descriptionErrPrecondition;
        }

        private ERepositoryStatus _repositoryType;

        /// <summary>
        /// Gets repositoryType.
        /// </summary>
        [IgnoreDataMember]
        public ERepositoryStatus RepositoryType
        {
            get { return _repositoryType; }
        }
    }
}

