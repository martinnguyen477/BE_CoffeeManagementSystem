using CoffeeManagementSystem.Model.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeManagementSystem.Model.BaseModel
{
    /// <summary>
    /// Model này dùng để trả ra result sau khi handler on Controller.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositoryModel<T>
    {
        /// <summary>
        /// Gets or sets parent code will display when return result.
        /// </summary>
        public string PartnerCode { get; set; }

        /// <summary>
        /// Gets or sets rowCount of the list after return result.
        /// </summary>
        public int RowCount { get; set; }

        private int _code = 0;

        /// <summary>
        /// Gets or sets retCode of data return. It is will define by user.
        /// </summary>
        public ERetCodeSystem RetCode
        {
            get { return (ERetCodeSystem)_code; }
            set { _code = (int)value; }
        }

        /// <summary>
        /// Gets or sets data of return result.
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets result Messenger of the data after get from database.
        /// </summary>
        public MessengerError Messenger { get; set; }

        /// <summary>
        /// Gets or sets result messenger flow languges if define by user.
        /// </summary>
        public ErrorMsgLanguage ErrorMsgObject { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryModel{T}"/> class.
        /// Return base response of result.
        /// </summary>
        /// <param name="retCode">retCode.</param>
        /// <param name="value">value.</param>
        public RepositoryModel(ERetCodeSystem retCode, T value)
        {
            this.RetCode = retCode;
            this.Data = value;
            this.RowCount = 0;
            this.Messenger = new MessengerError();
        }

        /// <summary>
        /// Error of language which define by user.
        /// </summary>
        public class ErrorMsgLanguage
        {
            public ErrorMsgLanguage()
            {
                Vi = "";
            }

            public string Vi { get; set; }
        }

        public RepositoryModel()
        {
            PartnerCode = "0";
            ErrorMsgObject = new ErrorMsgLanguage();
        }
    }

    public class MessengerError
    {
        /// <summary>
        /// Gets or sets thông báo lỗi từ hệ thống riêng theo từng chức năng.
        /// </summary>
        public string InternalMessage { get; set; }

        /// <summary>
        /// Gets or sets thông báo lỗi chuẩn từ Http.
        /// </summary>
        public string SystemMessage { get; set; }

        /// <summary>
        /// Gets or sets code mã lỗi theo chuẩn Https.
        /// </summary>
        public ERepositoryStatus HttpCode { get; set; }

        /// <summary>
        /// Gets or sets mã tracking để fix bug theo module.
        /// </summary>
        public string TraceId { get; set; }
    }
}
