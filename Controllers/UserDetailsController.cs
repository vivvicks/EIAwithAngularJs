﻿using EIAwithAngular.Filters;
using EIAwithAngular.Repository;
using System;
using System.Collections.Generic;
using System.Web.Http;
using EIAwithAngular.Models;
using System.Linq;
using System.Net;

namespace EIAwithAngular.Controllers
{
    [AntiForgeryValidate]
    public class UserDetailsController : ApiController
    {
        IVW_UserDetail _IVW_UserDetail;
        public UserDetailsController()
        {
            _IVW_UserDetail = new VW_UserDetailRepository(new EIA_DEVEntities());
        }

        // GET api/<controller>
        public IEnumerable<VW_UserDetail> Get(string TerminalCode)
        {
            try
            {
                return _IVW_UserDetail.LoadUsers(TerminalCode);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public IEnumerable<M_Airline_MST> Get()
        {
            try
            {
                return _IVW_UserDetail.AirlineList();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IEnumerable<VW_UserDetail> Get(String LoginID, String UserName, String ActiveStaus, String LockStatus)
        {
            try
            {
                return _IVW_UserDetail.SearchUsers(LoginID, UserName, ActiveStaus, LockStatus);
            }
            catch (Exception)
            {

                throw;
            }

        }

        // GET api/<controller>/5
        public VW_UserDetail Get(int id)
        {
            try
            {
                return _IVW_UserDetail.GetUserByID(id);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}