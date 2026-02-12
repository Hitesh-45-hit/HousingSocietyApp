using HousingSocietyApi.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSocietyApi.Core.Interface
{
    public interface ICommonInterface
    {
        public Task<account_grp_mst_DTO> AddAccountGroup(account_grp_mst_DTO account_Grp_Mst_DTO);
        public Task<install_mst_DTO> AddinstallData(install_mst_DTO install_Mst_);
    }
}
