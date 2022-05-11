using MediatR;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Http;

namespace ProjectEditor.WS.Controllers
{
    public class BaseController : Controller
    {
        private IMediator mediator;

        protected IMediator Mediator => this.mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    

    protected IMediator Mediator1
    {
        get
        {
            if (this.Mediator == null)
            {
                return HttpContext.RequestServices.GetService<IMediator>();
            }
            else
            {
                return this.Mediator;
            }

        }
    }

    protected T SetLocatioURI<T>(T result, string id)
    {
        if (result == null || string.IsNullOrWhiteSpace(id))
        {
            throw new HttpRequestException("Ressource is null!");
        }

        /* Aktueller URL ermitteln*/
        var baseURL = Request.HttpContext.Request.GetEncodedUrl();

        /* Base URL bis zum ersten Parameter, falls vorhanden, kürzen*/
        var length = baseURL.IndexOf('?') > 0 ? baseURL.IndexOf('?') : baseURL.Length;
        var uri = baseURL.Substring(0, length);

        /* ID an den gekürzten URL anhängen =< URI der neuen Ressource */
        uri = string.Concat(uri, uri.EndsWith("/") ? string.Empty : "/", id);

        /* Location header hinzufügen */
        HttpContext.Response.Headers.Add("Location", uri);

        /* Http-Status Code 201 - Created setzen */
        HttpContext.Response.StatusCode = (int)HttpStatusCode.Created;

        return result;
    }

    }

}

