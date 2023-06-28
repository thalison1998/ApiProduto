﻿namespace ApiWeb.Infra.CrossCutting.Core.ErrorMiddleware;
public class ErrorResponse
{
    public int StatusCode { get; set; }
    public string Message { get; set; }

    public ErrorResponse(int statusCode, string message)
    {
        StatusCode = statusCode;
        Message = message;
    }
}