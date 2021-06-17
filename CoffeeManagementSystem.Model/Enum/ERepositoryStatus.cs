namespace CoffeeManagementSystem.Model.Enum
{
    /// <summary>
    /// Enum này là 
    /// </summary>
    public enum ERepositoryStatus
    {
        /// <summary>
        /// Success.
        /// </summary>
        Success = 200,

        /// <summary>
        /// CreateSuccess.
        /// </summary>
        CreateSuccess = 201,

        /// <summary>
        /// NoContent.
        /// </summary>
        NoContent = 204,

        /// <summary>
        /// Error.
        /// </summary>
        Error = 400,

        /// <summary>
        /// InternalError.
        /// </summary>
        InternalError = 500,

        /// <summary>
        /// BadRequest.
        /// </summary>
        BadRequest = 404,

        /// <summary>
        /// Precondition.
        /// </summary>
        Precondition = 412,

        /// <summary>
        /// NoCookie.
        /// </summary>
        NoCookie = 999,

        /// <summary>
        /// Confict.
        /// </summary>
        Confict = 409
    }
}
