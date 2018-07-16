﻿namespace Commmunity.AspNetCore.ExceptionHandling.Handlers
{
    public enum HandlerResult
    {
        ReThrow = 0,

        NextHandler = 1,

        NextChain = 2,

        Retry = 3,

        Handled = 4
    }
}