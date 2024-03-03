using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDAbastillasAD.Repository;

namespace CRUDAbastillasAD.Controllers
{
    public class BaseController : Controller
    {
        public CRUDEntities _db;
        public BaseRepository<UserAccount> _userRepo;
        public BaseController()
        {
            _db = new CRUDEntities();
            _userRepo = new BaseRepository<UserAccount>();
        }
    }
}