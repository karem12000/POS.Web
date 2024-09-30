using Mapster;
using POS.Common;
using POS.DAL;
using POS.DTO;
using POS.DTO.Guide;
using POS.Tables.Models;

namespace POS.BLL.Guide
{
    public class StockBll(IRepository<Store> repoStock)
    {
        private readonly IRepository<Store> _repoStock = repoStock;

        public ResultViewModel Save(StockDto mdlDto)
        {
            var result = new ResultViewModel() { Status = false, Message = AppConstant.Messages.InvalidSave };

            if (mdlDto == null)
            {
                return result;
            }
            if (string.IsNullOrEmpty(mdlDto.Name))
            {
                result.Message = AppConstant.Messages.NameRequired;
                return result;
            }
            if (string.IsNullOrEmpty(mdlDto.PhoneNum))
            {
                result.Message = AppConstant.Messages.PhoneRequired;
                return result;
            }
            var existStore = _repoStock.GetAllAsNoTracking().Any(x => x.Name == mdlDto.Name);
            if (existStore)
            {
                result.Message = AppConstant.Messages.NameAlreadyExists;
                return result;
            }
            var newStock = mdlDto.Adapt<Store>();

            var SaveResult = _repoStock.Insert(newStock);
            if (SaveResult)
            {
                result.Status = true;
                result.Message = AppConstant.Messages.SuccessSave;
                return result;
            }

            return result;
        }


    }
}
