using AutoMapper;
using PVenta.Models.ApiModels;
using PVenta.Models.Model;
using PVenta.Services;
using PVenta.Utility;
using PVenta.WebApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace PVenta.WebApi.Controllers
{
    public class ErrorListController : ApiController
    {
        private readonly AutoMapper.MapperConfiguration objMapper;
        private readonly ServiceErrorList serviceErrorList;

        public ErrorListController()
        {
            serviceErrorList = new ServiceErrorList();

            List<Profile> profileList = new List<Profile>();
            profileList.Add(new ErrorListProfile());
            profileList.Add(new MErrorListProfile());
            

            objMapper = new MapperConfiguration(i => i.AddProfiles(profileList));
        }
    
        public JsonResult<List<ApiErrorList>> GetErrorLists()
        {
            List<ErrorList> errorListsLista = serviceErrorList.GetErrorLists();
            List<ApiErrorList> errorLists = objMapper.CreateMapper().Map<List<ApiErrorList>>(errorListsLista);
            return Json<List<ApiErrorList>>(errorLists);
        }

        public JsonResult<ApiErrorList> GetErrorList(string id)
        {
            ErrorList errorListLista = serviceErrorList.GetErrorList(id);
            ApiErrorList errorList = objMapper.CreateMapper().Map<ApiErrorList>(errorListLista);
            return Json<ApiErrorList>(errorList);
        }

        [HttpPost]
        public JsonResult<MessageApp> InsertErrorList(ApiErrorList errorListNew)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                ErrorList errorListInsert = objMapper.CreateMapper().Map<ErrorList>(errorListNew);
                result = serviceErrorList.InsertErrorList(errorListInsert);
            }
            return Json<MessageApp>(result);
        }

        [HttpPost]
        public JsonResult<MessageApp> UpdateErrorList(ApiErrorList errorListUpd)
        {
            MessageApp result = null;
            if (ModelState.IsValid)
            {
                ErrorList errorListUpdate = objMapper.CreateMapper().Map<ErrorList>(errorListUpd);
                result = serviceErrorList.UpdateErrorList(errorListUpdate);
            }
            return Json<MessageApp>(result);
        }

        [HttpPost]
        public JsonResult<MessageApp> DeleteErrorList(string id)
        {
            MessageApp result = null;
            
            result = serviceErrorList.DeleteErrorList(id);
            
            return Json<MessageApp>(result);
        }

    }
}
