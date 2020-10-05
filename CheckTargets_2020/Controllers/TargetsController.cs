using CheckTargets_2020.DBModel;
using CheckTargets_2020.DBModel.DBObjects;
using CheckTargets_2020.DBModel.DBObjects.Contracts;
using CheckTargets_2020.Models;
using CheckTargets_2020.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckTargets_2020.Controllers
{
    public class TargetsController : Controller
    {
        private IRepositoryWrapper _repoWrapper;
        public TargetsController(IRepositoryWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        public IActionResult Index()
        {

            //var targets = _repoWrapper.Targets.List();
            List<DTOTargets> targets = (from t in _repoWrapper.Targets.List()
                                        select new DTOTargets
                                        {
                                            ID = t.ID,
                                            Name = t.Name,
                                            Url = t.Url,
                                            State = t.State,
                                            CreateTime = t.CreateTime,
                                            UpdateTime = t.UpdateTime,
                                            CreatedByID = t.CreatedByID
                                        }).ToList();


            return View(targets);
        }

        public IActionResult Create(int targetIdHttpPost)
        {

            return View();
        }
        [HttpPost]
        public JsonResult Create(DTOTargets target)
        {
            try
            {

                Targets trg = new Targets();
                trg.CreateTime = DateTime.Now;
                trg.Name = target.Name;
                trg.State = target.State;
                trg.Url = target.Url;
                trg.CreatedByID = 1;
                _repoWrapper.Targets.Insert(trg);

                return Json(trg);




            }
            catch (Exception)
            {

                return Json(-1);
            }

        }

        public JsonResult Notify(int id)
        {
            try
            {


                MailNotification mNotif = new MailNotification();
                mNotif.SourceMail = "habib.kalcik@gmail.com";
                mNotif.TargetMail = "habib.kalcik@hotmail.com";


                //SMSNotification mNotif = new SMSNotification();
                //mNotif.Phone = "05462948416";

                Notification notification = new Notification(mNotif);
                notification.Message = "Message";


                var currentTarget = _repoWrapper.Targets.GetById(id);
                Notifications ntfs = new Notifications();
                ntfs.TargetID = currentTarget.ID;
                ntfs.UserId = 1;
                ntfs.TargetContact = mNotif.TargetMail;
                if (currentTarget.State)
                    ntfs.Message = "Target is working!";
                else
                    ntfs.Message = "Target is Stopped!";

                _repoWrapper.Notifications.Insert(ntfs);

                notification.Notify();

                return Json(ntfs);

            }
            catch (Exception)
            {
                return Json(-1);
            }
        }
    }
}
