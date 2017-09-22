using AutoMapper;
using HauLe.Service;
using HauLe.WebApi.Infrastructure.Core;
using HauLe.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Linq;

namespace HauLe.WebApi.Controllers
{
    [RoutePrefix("api/brand")]
    public class BrandController : ApiControllerBase
    {
        private IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            this._brandService = brandService;
        }

        [Route("getall")]
        [HttpGet]
        public HttpResponseMessage GetAll(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var requestItem = _brandService.GetAll();
                var responeModel = Mapper.Map<List<BrandViewModel>>(requestItem.ToList());
                var requestData = request.CreateResponse(HttpStatusCode.OK, responeModel);
                return requestData;
            });
        }
    }
}
