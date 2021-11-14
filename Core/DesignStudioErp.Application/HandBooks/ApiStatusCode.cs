using System.Net;

namespace DesignStudioErp.Application.HandBooks;

/// <summary>
/// Http statuses Web API
/// </summary>
public enum ApiStatusCode
{
    /// <summary>
    /// Http Ok = 200
    /// </summary>
    OK = HttpStatusCode.OK,

    /// <summary>
    /// Http Created = 201
    /// </summary>
    Created = HttpStatusCode.Created,

    /// <summary>
    /// Http NoContent = 204
    /// </summary>
    NoContent = HttpStatusCode.NoContent,

    /// <summary>
    /// Http BadRequest = 400
    /// </summary>
    BadRequest = HttpStatusCode.BadRequest,

    /// <summary>
    /// Http Forbidden = 403
    /// </summary>
    Forbidden = HttpStatusCode.Forbidden,

    /// <summary>
    /// Http NotFound = 404
    /// </summary>
    NotFound = HttpStatusCode.NotFound,

    /// <summary>
    /// Http InternalServerError = 500
    /// </summary>
    InternalServerError = HttpStatusCode.InternalServerError,
}

