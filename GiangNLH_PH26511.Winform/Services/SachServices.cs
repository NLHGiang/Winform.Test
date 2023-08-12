using GiangNLH_PH26511.Winform.Domain;
using GiangNLH_PH26511.Winform.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiangNLH_PH26511.Winform.Services
{
    internal class SachServices
    {
        SachRepository _sachRepo;

        public SachServices()
        {
            _sachRepo = new();
        }

        public List<Sach> GetAll(string textSearch)
        {
            return _sachRepo.GetAll(textSearch);
        }

        public bool Add(Sach sach)
        {
            return _sachRepo.Add(sach);
        }

        public bool Delete(Guid id)
        {
            return _sachRepo.Delete(id);
        }

        public bool CheckDuplicateMaSach(string maSach)
        {
            return _sachRepo.CheckDuplicateMaSach(maSach);
        }
    }
}
