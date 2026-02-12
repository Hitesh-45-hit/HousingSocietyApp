using AutoMapper;
using HousingSocietyApi.Core.DTO;
using HousingSocietyApi.Core.Interface;
using HousingSocietyApi.DataModel.Tables;
using ServiceManagement.Infrastructure.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSocietyApi.Infrastructure.Services
{

    public class CommonService : ICommonInterface
    {
        private readonly AppDbContext _dBContext;
        private readonly IMapper _mapper;

        public CommonService(AppDbContext dBContext, IMapper mapper)
        {
            _dBContext = dBContext;
            _mapper = mapper;
        }

        public async Task<account_grp_mst_DTO> AddAccountGroup(account_grp_mst_DTO account_Grp_Mst_DTO)
        {
            try
            {
                var accountGroup = _mapper.Map<account_grp_mst>(account_Grp_Mst_DTO);
                _dBContext.account_grp_mst.Add(accountGroup);
                await _dBContext.SaveChangesAsync();
                return account_Grp_Mst_DTO;
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw new Exception("An error occurred while adding the account group.", ex);
            }
        }

        public async Task<install_mst_DTO> AddinstallData(install_mst_DTO install_Mst_)
        {
            try
            {
                var installData = _mapper.Map<install_mst>(install_Mst_);
                _dBContext.install_mst.Add(installData);
                await _dBContext.SaveChangesAsync();
                return install_Mst_;
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                throw new Exception("An error occurred while adding the install data.", ex);
            }
        }
    }
}
