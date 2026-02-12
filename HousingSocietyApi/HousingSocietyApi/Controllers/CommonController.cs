using HousingSocietyApi.Core.DTO;
using HousingSocietyApi.Core.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingSocietyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private ICommonInterface _commonService;

        public CommonController(ICommonInterface commonService)
        {
            _commonService = commonService;
        }

        [HttpPost("AddAccountGroup")]
        public async Task<ActionResult> AddLeadGeneration([FromBody] account_grp_mst_DTO account_Grp_Mst_DTO)
        {
            account_grp_mst_DTO result = await _commonService.AddAccountGroup(account_Grp_Mst_DTO);
            return Ok(result);
        }

        [HttpPost("AddinstallData")]
        public async Task<ActionResult> AddinstallData([FromBody] install_mst_DTO install_Mst_)
        {
            install_mst_DTO result = await _commonService.AddinstallData(install_Mst_);
            return Ok(result);
        }

    }
}
