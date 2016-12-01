﻿using System;
using System.Linq;
using System.Web.Http;
using System.Collections.Generic;
using Marketing.Data.Services;
using System.Threading.Tasks;

namespace Marketing.API.Controllers
{
    [RoutePrefix("api/ProductDescriptions")]
    public class ProductDescriptionsController : ApiController
    {
        private readonly ProductDescriptionService _service;

        public ProductDescriptionsController(ProductDescriptionService service)
        {
            _service = service;
        }

        [HttpGet, Route("ByStockItem")]
        public async Task<IEnumerable<dynamic>> ByStockItem(string ids)
        {
            var _ids = ids.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            return await _service.GetByStockItem(_ids);
        }
    }
}
