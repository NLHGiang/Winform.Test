using GiangNLH_PH26511.Winform.Context;
using GiangNLH_PH26511.Winform.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiangNLH_PH26511.Winform.Repositories
{
    internal class SachRepository
    {
        FinalassFpolyNetJavaSm22Bl2Context _dbContext;

        public SachRepository()
        {
            _dbContext = new();
        }

        // Get All
        public List<Sach> GetAll(string textSearch)
        {
            if (string.IsNullOrWhiteSpace(textSearch))
            {
                var listObj = _dbContext.Saches.ToList();

                return listObj;
            }
            else
            {
                var listObj = _dbContext.Saches.Where(c => c.Ten.Contains(textSearch)).ToList();

                return listObj;
            }
        }

        // Get By Id
        public Sach? GetById(Guid id)
        {
            var obj = _dbContext.Saches.FirstOrDefault(c => c.Id == id);

            return obj;
        }

        // Add
        public bool Add(Sach sach)
        {
            try
            {
                sach.Id = Guid.NewGuid();

                _dbContext.Add(sach);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Update
        public bool Update(Guid id, Sach sach)
        {
            try
            {
                var obj = GetById(id);
                if (obj == null)
                {
                    return false;
                }

                obj.Ma = sach.Ma;
                obj.Ten = sach.Ten;
                obj.DonGia = sach.DonGia;
                obj.SoTrang = sach.SoTrang;

                _dbContext.Update(obj);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Delete
        public bool Delete(Guid id)
        {
            try
            {
                var obj = GetById(id);
                if (obj == null)
                {
                    return false;
                }

                _dbContext.Remove(obj);
                _dbContext.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool CheckDuplicateMaSach(string maSach)
        {
            var obj = _dbContext.Saches.FirstOrDefault(c => c.Ma == maSach);

            if (obj == null)
            {
                return false;
            }

            return true;
        }
    }
}
